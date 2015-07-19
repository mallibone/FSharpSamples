namespace FSharpWebSample.Controllers
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http
open FSharpWebSample.Models

/// Retrieves values.
type CarsController() =
    inherit ApiController()

    let values = [ { Make = "Ford"; Model = "Mustang"; Id = 1 }; { Make = "Nissan"; Model = "Titan"; Id = 2 }; { Make = "Audi"; Model = "R8"; Id = 3 } ]

    /// Gets all values.
    member x.Get() = values

    member x.Get(id:int) = values |> List.filter(fun v -> v.Id = id)