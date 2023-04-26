# API-final-project
Dear Professor Canca,

First off, I want to begin by saying thank you so much for the countless tips and office hours you provided to me while
I was learning in your class. I had no prior knowledge about API's and was afraid of falling behind in your class. 
However, your motivation and clear explanations on ideas really helped me make alot of progress in this 
API. As a result, after a long long time of debugging, running through errors, and researching on stackoverflow,
I present to you MY SOCCER API.

The reason behind creating MY SOCCER API is because I wanted to be able to track and record my favorite soccer team's 
season through their tournament:Barcelona. By doing so, I would also be learning how to make and functionize an API to 
the best of my ability.

MY SOCCER API has checked off on having at least 3 HTTP methods, 3 API endpoints, and at least one controller.
------------------------------------------------------------------------------
• What are the different endpoints that a client can use? 
There are 4 different endpoints the client can use. They are:
1. GET url = "https://localhost:5001/api/team"
2. GET url = "https://localhost:5001/api/team/2"
3. PUT url = "https://localhost:5001/api/team/2"
4. POST url = "https://localhost:5001/api/team"

The function of the 4 HTTP methods and API endpoints are :

// GET: api/team         **retrieves all of the teams in the table

// GET: api/team/5       **retrieves a specific team in the table

// POST: api/team        **Add a new team entry in the table

// PUT: api/team/{teamNo} **Change information on a specific team in the table

1 controller in my API named "TeamController" folder
--------------------------------------------------------------------------------
• Sample request bodies, if applicable? 
Example screenshots on GitHub README
--------------------------------------------------------------------------------
• Sample response body?
Example screenshots on GitHub README
------------------------------------------------------------------------------------
If I had more time and knowledge about C Sharp, I would try to create another controller that would help us get 
information from the players table. I also would make a DELETE method because I was running into a bunch of foreign 
errors and bad request issues.
