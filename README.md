<h1 align="center">Welcome to com.gameframe.giphy 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-1.0.0-blue.svg?cacheSeconds=2592000" />
  <a href="https://openupm.com/packages/com.gameframe.giphy/">
    <img src="https://img.shields.io/npm/v/com.gameframe.giphy?label=openupm&amp;registry_uri=https://package.openupm.com" />
  </a>
  <a href="https://twitter.com/coryleach">
    <img alt="Twitter: coryleach" src="https://img.shields.io/twitter/follow/coryleach.svg?style=social" target="_blank" />
  </a>
</p>

> This package contains a simple implementation of the Giphy API required to display random Gif images in Unity as MP4 videos.</br>
> This package does not provide a means to display a gif directly but does provide urls to gif version of the images.</br>
> Instead this package uses the mp4 links provided by giphy's api to display the gifs as movies.</br>

## Quick Package Install

#### Using UnityPackageManager (for Unity 2019.3 or later)

Open the package manager window (menu: Window > Package Manager)<br/>
Select "Add package from git URL...", fill in the pop-up with the following link:<br/>
https://github.com/coryleach/UnityGiphy.git#1.0.0<br/>

#### Using OpenUPM

The package is available on the [openupm registry](https://openupm.com/packages/com.gameframe.giphy/). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli#openupm-cli).

```
openupm add com.gameframe.giphy
```

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
You can use your config asset and the demo scene included in this package to get started.

This library provides a GiphyRawImageController component that can be used with RawImage and VideoPlayer
for displaying random giphy images in your UI but example API code is also shown below.

```C#
//You can make basic queries to Giphy using the API provide in the GiphyQuery class.
//As of this writing only Random and Search endpoints are supported.
//For more info on the query results please see the following documentation
// https://developers.giphy.com/docs/api/endpoint

//Example code that loads a random image and plays it as a video
public async void ShowRandomImage()
{
  //Get a single random result
  var randomResult = await GiphyQuery.Random(apiKey,searchKeywords);

  //Display the random image result using Unity's video player
  videoPlayer.source = VideoSource.url;
  videoPlayer.url = randomResult.result.data.images.original_mp4.mp4;
  videoPlayer.Play();
}
```

## Author

👤 **Cory Leach**

* Twitter: [@coryleach](https://twitter.com/coryleach)
* Github: [@coryleach](https://github.com/coryleach)

## Show your support

Give a ⭐️ if this project helped you!

***
_This README was generated with ❤️ by [readme-md-generator](https://github.com/kefranabg/readme-md-generator)_
