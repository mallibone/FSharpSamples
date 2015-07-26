namespace FSharpWebSample.Test
open Xunit
open FSharpWebSample.Controllers

module CarsControllerTest =

    let carsController = new CarsController()

    [<Fact>]
    let Get_WhenInvoked_ReturnsAListContainingMultipleElements() = 
        let cars = carsController.Get()
        Assert.False(cars.IsEmpty)

    [<Fact>]
    let GetWithIndex_WhenInvokedWithAValidIndex_ReturnsASingleItem() = 
        let car = carsController.Get(2)
        Assert.True(car.Id = 2)
