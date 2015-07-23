namespace FSharpWebSample.Test
open Xunit
open FSharpWebSample.Controllers

module CarsControllerTest =
    [<Fact>]
    let Get_WhenInvoked_ReturnsAListContainingMultipleElements() = 
        let carsController = new CarsController()
        let cars = carsController.Get()
        Assert.False(cars.IsEmpty)
