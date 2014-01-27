Hello.

As you might have noticed, we managed to screw up the account activation. That's what you get for having a closed beta with users that had registered once. The problem was that the we changed the authentication routine when we separated the UI from the backend (we are using a RESTful service now). Hence everyone that activated their accounts only got one cookie. 

Apart from that we've also fixed bugs and implemented changes based on feedback from all registered users.

* Adjusted the size on the charts
* Made it simpler to add the credentials to the client library
* Much better error messages in the client libraries if the appkey or shared secret are incorrect.
* You are redirected to the login page if the RESTful api session have expired.
* General UI changes
* Updated the client documentation
* Added support for deep object graphs when adding context information to the exception.

We've also made several examples for the client library which are available at https://github.com/onetrueerror/Examples.

Please keep the feedback coming. It's highly appreciated.

Best regards,
  The OneTrueError Team.