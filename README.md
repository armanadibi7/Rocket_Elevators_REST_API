# Rocket_Elevators_REST_API



Implemented using ASP.NET WEB API to deploy this REST API on Microsoft Azure. Here is the website http://rocket-elevators-rest-api.azurewebsites.net




Get all the interventions that are In the pending Status.
GET:

```
http://rocket-elevators-rest-api.azurewebsites.net/intervention 

```


Update the status of an intervention to InProgress and the DateTime.

**** Make Sure the Spelling is Correct for the Status ****

PUT: http://rocket-elevators-rest-api.azurewebsites.net/intervention

```
{ 'id': 1,
'status': 'InProgress'}


```


Update the status of an intervention to a Completed and add the DateTime

PUT: http://rocket-elevators-rest-api.azurewebsites.net/intervention

```
{ 'id': 1,
'status': 'Completed'}



```
