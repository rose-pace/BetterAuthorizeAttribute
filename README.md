# BetterAuthorizeAttribute
An authrorize attribute that lets you use an array of roles or users rather than creating a comma-delimited string

Roles Example:
```
[BetterAuthorize(RoleList = new[] { Roles.Role01, Roles.Role02 })]
public class MyController : Controller
{
    ...
```

Users Example:
```
[BetterAuthorize(UserList = new[] { Users.User01, Users.User02 })]
public class MyController : Controller
{
    ...
```
