namespace MinimalJwt.Repositories

open MinimalJwt.Models.User

module UserRepository =
    let Users: list<User> =
        [ { UserName = "ronanzin"
            Email = "g@gmail.com"
            Password = "saopaulo123"
            GivenName = "Gabriel"
            Surname = "Morelli"
            Role = "admin" } ]
