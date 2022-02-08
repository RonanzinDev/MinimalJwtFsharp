namespace MinimalJwt.Repositories

module MovieRepository =
    open MinimalJwt.Models.Movie

    let movies =
        [ { id = 1
            title = "Eternals"
            description = "to  good"
            ratio = 8.2 }

          { id = 2
            title = "avengers"
            description = "fucking good"
            ratio = 10.0 }

          ]
