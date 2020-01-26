# Sonia_Scoop

PROPOSAL IMPLEMENTATION 

Scope Design For Web API using IdentityServer4 . 

Case : Factory - Line Assembly / Logistic / HR / Warehouse

This is Scope Design For IdentityServer4 based on a specific case. This design trying to point out the best practice that we might use when designing our area of data that we want to protect , The Scopes then will work alongside with claims and assigned to users.

In this example design, we are trying to implement a specific company policy implementation , where it stated that data within our enterprise need to be protected from individual based on their role in a specific domain. 

We are taking advantage of centralized solution using IdentityServer4

Note : In this design case we are making use of In Memory Data.


Infrastructure/Microservices Involved.

1.Authentication/Token Provider - Identity Server 4

2.Web API - Human Resource Module 

3.Web API - SMT Machine Assembly Line Module

4.Web API - Product Assembly Line Module

5.Web API - Warehouse Module

// Note . The proposed design is based on requirement where role is the claims, it is advised to use policy as the permissions.

# Special Thanks To 

IdentityServer 4 : [View License](https://github.com/IdentityServer/IdentityServer4/blob/master/LICENSE)

IdentityModel : [View License](https://github.com/IdentityModel/IdentityModel/blob/master/LICENSE) 
