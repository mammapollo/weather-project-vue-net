# weather-project-vue-net
 
Weather project vue net is a simple project to show how to handle API calls in Vue (version 3, typescript based) and ASP.NET core (version 8).

The UI shows 3 cities for which it is possible to find weather information.

By clicking on one of the buttons, information relating to the chosen city will be shown in the panel below.

![immagine](https://github.com/mammapollo/weather-project-vue-net/assets/110206243/527214b0-bd6e-4cf8-830d-066bbbe3502a) 
![immagine](https://github.com/mammapollo/weather-project-vue-net/assets/110206243/9f0a8952-b22c-4780-bcb7-df4636f3b90f)


# Project structure

When the user requests information via interface, a call will be made to the ASP.NET Core server. 

The call will contain the name of the selected city and will be forwarded to the RapidAPI service from which the information will be extracted.

# How to run
To correctly configure the client and run it, you need to set the server endpoint in the specific production or development section. 

During the build phase, the values chosen for production will be set, while during the development phase, the values chosen for development will be set.

![immagine](https://github.com/mammapollo/weather-project-vue-net/assets/110206243/f866fba7-f293-4246-aa20-141ca9428b76)

To correctly configure the server it is necessary to set the value of the RapidAPI key we want to use in the appconfig.json file. 
This value will also need to be set on the production server (for example if we choose to use Azure, we will set as a secret).

![immagine](https://github.com/mammapollo/weather-project-vue-net/assets/110206243/28d73d5e-f9ef-46ee-878e-63aad35f031b)

If we want to run the project locally we need to manage CORS permissions. 

By default calls to the server will fail if the server and client do not have identical scheme, domain and port.

To handle this case in local development, simply set a CORS permission in the Program.cs file of the server project to be able to respond correctly to the specified address.

For example in Program.cs:

![immagine](https://github.com/mammapollo/weather-project-vue-net/assets/110206243/61ac7f10-0aa7-4a48-96da-4fa35f492742)

and

![immagine](https://github.com/mammapollo/weather-project-vue-net/assets/110206243/d11aebcd-28f0-4350-a779-42a9ec854cf0)

# Fun and errors

During the data feed a gif containing a potion making bubbles is shown :blush:

![loading](https://github.com/mammapollo/weather-project-vue-net/assets/110206243/d9c00172-7e69-4df9-b4f0-6d151ad5d46e)

If for any reason the call to the server fails, an error message is displayed.

![immagine](https://github.com/mammapollo/weather-project-vue-net/assets/110206243/e801c8ea-8026-4842-b97e-4641b919c940)



