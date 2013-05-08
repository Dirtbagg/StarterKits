#Meetup/Bing Maps Starter Kit
##Date: 05/08/2013
##Version: v0.0.1
##Author(s): G. Andrew Duthie
##URL: http://github.com/apimash/starterkits

----------
###Description
The Meetup/Bing Maps Starter Kit is a native HTML5 and JavaScript Windows Store app based on the Grid App template. It leverages the Meetup.com API to search for upcoming meetups near a given location, with optional keyword filtering. Once the meetups are retrieved, the starter kit maps a selected item, and queries the Bing Maps Search API for nearby coffee shops, and maps those as well.


###Features
 - Demonstrates using WinJS.xhr to call the [Meetup.com API][1]
 - Demonstrates integrating Bing Maps, and calling the Bing Maps Search API
 - Demonstrates how to load live data into the JavaScript Grid App template, and how to adapt the live data to display with minimal customization to the HTML and JavaScript files in the template
 - Leverages SVG for item images, for easy scaling
 - Demonstrates the use of the Settings contract to provide About and Privacy pages
 - Demonstrates the use of the Share Source contract, to easily share app content with other installed apps
 - List item

###Requirements
 - Meetup API Key (don't use your day-to-day meetup ID for this...create a unique account, and sign up for a key [here][2])
 - Bing Maps API Key (sign up [here][3] - Microsoft Account required for the Bing Maps Portal)
 - Windows Store Account (to submit app for certification)

###Setup
Basic customization is done via the file customizeMe.js, found in the js folder. Here are the key items you can customize:

 - meetupKey: Your custom Meetup API key
 - meetupDistance: Distance, in miles, for search. Default is 50
 - maxMeetupstoFind: Maps to the Meetup API parameter 'page'. Use with the 'offset' parameter to implement paging. Default is 200
 - meetupCity: City where you want to find upcoming Meetups
 - meetupState: State where you want to find upcoming Meetups
 - meetupKeywords: Optional keyword(s) to filter response. Can help in limiting response to a specific topic. Default is "JavaScript"
 - bingMapsKey: Your custom Bing Maps API key
 - shareTitle: Default text for Share contract Title property
 - shareMessage: Default text for Share contract Text property
 
More advanced customization is possible by digging into the code and stylesheets. All logic for retrieving and grouping Meetup data may be found in js/meetupData.js. App-wide styles may be found in css/default.css, and page-specific styles may be found in each respective page folder.

###Known Issues
Here are the currently known issues (aka learning opportunities for the developer):

 - Snapped View: Snapped view is partially implemented (via the CSS media queries from the Grid App template), but the snapped view will need to be improved prior to submitting an app for the Windows Store.
 - App Images: Splash Screen, app tile logos, etc. need to be provided prior to submitting an app based on this starter kit for certification in the Windows Store

----------

##Change Log
###v0.0.1
Initial Version

  [1]: http://www.meetup.com/meetup_api/ "Meetup API"
  [2]: http://www.meetup.com/meetup_api/ "Meetup API"
  [3]: https://www.bingmapsportal.com/ "Bing Maps Portal"