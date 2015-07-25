namespace FSharpWebSample.Test
open Xunit
open FSharpWebSample.Controllers

module CarsControllerTest =
    [<Fact>]
    let Get_WhenInvoked_ReturnsAListContainingMultipleElements() = 
        let carsController = new CarsController()
        let cars = carsController.Get()
        Assert.False(cars.IsEmpty)

    [<Fact>]
    let GetWithIndex_WhenInvokedWithAValidIndex_ReturnsASingleItem() = 
        let carsController = new CarsController()
        let car = carsController.Get(2)
        Assert.True(car.Id = 2)
