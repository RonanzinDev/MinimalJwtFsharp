namespace MinimalJwt.Services

module UserService =
    open MinimalJwt.Services.IUserService
    open MinimalJwt.Repositories.UserRepository
    open System.Linq
    open System

    type UserService =
        interface IUserService with
            member this.Get(userLogin) =
                let user =
                    Users.FirstOrDefault (fun o ->
                        o.UserName.Equals(userLogin.UserName, StringComparison.OrdinalIgnoreCase)
                        && o.Password.Equals(userLogin.Password))

                user
