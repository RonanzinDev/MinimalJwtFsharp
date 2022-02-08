namespace MinimalJwt.Models

module User =

    type User =
        { UserName: string
          Email: string
          Password: string
          GivenName: string
          Surname: string
          Role: string }
