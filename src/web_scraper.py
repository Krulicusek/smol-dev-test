```python
import os
import requests
from bs4 import BeautifulSoup

class WebScraper:
    def __init__(self, url, assets_dir):
        self.url = url
        self.assets_dir = assets_dir

    def scrape_images(self):
        response = requests.get(self.url)
        soup = BeautifulSoup(response.text, 'html.parser')
        images = soup.find_all('img')

        for image in images:
            img_url = image['src']
            if img_url.startswith('http'):
                img_data = requests.get(img_url).content
                img_name = os.path.join(self.assets_dir, 'images', os.path.basename(img_url))
                with open(img_name, 'wb') as handler:
                    handler.write(img_data)

    def scrape_sounds(self):
        response = requests.get(self.url)
        soup = BeautifulSoup(response.text, 'html.parser')
        sounds = soup.find_all('audio')

        for sound in sounds:
            sound_url = sound['src']
            if sound_url.startswith('http'):
                sound_data = requests.get(sound_url).content
                sound_name = os.path.join(self.assets_dir, 'sounds', os.path.basename(sound_url))
                with open(sound_name, 'wb') as handler:
                    handler.write(sound_data)

if __name__ == "__main__":
    scraper = WebScraper('http://example.com', 'assets/')
    scraper.scrape_images()
    scraper.scrape_sounds()
```