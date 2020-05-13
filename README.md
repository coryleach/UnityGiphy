<h1 align="center">Welcome to com.gameframe.giphy 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-1.0.0-blue.svg?cacheSeconds=2592000" />
  <a href="https://twitter.com/coryleach">
    <img alt="Twitter: coryleach" src="https://img.shields.io/twitter/follow/coryleach.svg?style=social" target="_blank" />
  </a>
</p>

> This package contains a simple implementation of the Giphy API required to display random Gif images in Unity as MP4 videos.</br>

## Quick Package Install

#### Using UnityPackageManager (for Unity 2019.3 or later)
Open the package manager window (menu: Window > Package Manager)<br/>
Select "Add package from git URL...", fill in the pop-up with the following link:<br/>
https://github.com/coryleach/UnityGiphy.git#1.0.1<br/>

#### Using UnityPackageManager (for Unity 2019.1 or later)

Find the manifest.json file in the Packages folder of your project and edit it to look like this:
```js
{
  "dependencies": {
    "com.gameframe.giphy": "https://github.com/coryleach/UnityGiphy.git#1.0.0",
    ...
  },
}
```

## Usage

To get started you must create an app and get an API key on the https://developers.giphy.com/ website.<br />
Create your GiphyConfig asset by using the Create->Gameframe->Giphy->Config in the project tab's Create menu.<br />
Once you have created your GiphyConfig asset you should add your API key to it that you got from the Giphy developer website.<br />
You can use your config asset and the demo scene included in this package to get started


```C#
//You can make basic queries to Giphy using the API provide in the GiphyQuery class.
//For more info on the query results please see the following documentation
// https://developers.giphy.com/docs/api/endpoint

//Search for multiple images. By default you will get back 25 entries. Result is paginated.
var searchResult = GiphyQuery.Search(apiKey,searchKeywords);

//Get back a single random image
var randomResult = GiphyQuery.Random(apiKey,searchKeywords);

```

## Author

👤 **Cory Leach**

* Twitter: [@coryleach](https://twitter.com/coryleach)
* Github: [@coryleach](https://github.com/coryleach)

## Show your support

Give a ⭐️ if this project helped you!

***
_This README was generated with ❤️ by [readme-md-generator](https://github.com/kefranabg/readme-md-generator)_
