namespace MinimalJwt.Services


module IUserService =

    open MinimalJwt.Models.User
    open MinimalJwt.Models.UserLogin

    type IUserService =
        abstract member Get : userLogin: UserLogin -> User
