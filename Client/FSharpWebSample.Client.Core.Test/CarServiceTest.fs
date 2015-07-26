namespace FSharpWebSample.Client.Core.Test
open FSharpWebSample.Client.Core.Models
open Xunit
open Newtonsoft.Json


type ClientHttpService() =
    member this.Get(uri:string) =
        let response = uri
        ""

type CarService(httpService:ClientHttpService) =

    let _carService = httpService
    let _uri = ""

    member this.GetCars() =
        let jsonResponse = _carService.Get(_uri)
        let response = JsonConvert.DeserializeObject<List<Car>>(jsonResponse)
        response
//        [ { Make = "Ford"; Model = "Mustang"; Id = 1 }; { Make = "Nissan"; Model = "Titan"; Id = 2 }; { Make = "Audi"; Model = "R8"; Id = 3 } ]

type CarsServiceTest() = 

    [<Fact>]
    let GetCars_WhenInvoked_ReturnsAListOfCars() =
        let carService = new CarService(new ClientHttpService())
        let cars = carService.GetCars()
        Assert.False(cars.IsEmpty)

