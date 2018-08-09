let icereamShop: string = "Karlos Parlor"
open System.Net
open System.Security.Claims

let icecream1 = "strawberry"

let icream2 = "Vanilla"

let price = 0.9

let mutable price2 = 1.0

price2 <- 4.0

let resultsofday amountofScoop =
    amountofScoop * 0.5

resultsofday 2.


let resultofDay (AmountofScoop : float) =
    AmountofScoop * 2.

resultofDay 2.

let dayResults sold price =
    sold * price

dayResults 25. 3.

type SpecialFlavor = 
    |   Redrising
    |   Dreamcream

type Flavor =
    |   Strawberry
    |   Vanilla 

let flavorPrice Flavor =
    match Flavor with
    | Strawberry ->
        1.1
    | Vanilla  ->
        0.9

dayResults 100. (flavorPrice Strawberry)

let strawberryRevenue =
    "strawberry"
    |> flavorPrice
    |> dayResults 10.

let othersRevenue =
    " "
    |> flavorPrice
    |> dayResults 15.

let resultsFor ice sold =
    ice
        |> flavorPrice
        |> dayResults sold

resultsFor "strawberry" 100. + resultsFor "vanilla" 50.

let iceName Flavor =
    match Flavor with
    | Redrising ->
        Strawberry
    | Dreamcream ->
        Vanilla

"red rising"
    |> iceName
    |> flavorPrice
    |>dayResults 100.

let iceToPrice =
    iceName >> flavorPrice

iceToPrice "red rising"

let priceForSpecial =
    iceName >> flavorPrice

// map all the items in the list below to their price
// map all the items in the list below to their price
// list.map takes 2 parameters to produce 3rd parameter. 2nd paramter is the list. 1st parameter is a function, which is usually called first class citizens.
// then add to know the full revenue from the sale of the items

let sales = 
    [
        Redrising
        Dreamcream
        Redrising
        Redrising
        Dreamcream
    ]

sales
|> List.map (fun Flavor -> priceForSpecial Flavor)
|> List.sum

sales
|> List.map priceForSpecial
|> List.sum

sales
|> List.filter (fun flavor -> flavor = "red rising")
|> List.map priceForSpecial
|> List.map (fun x -> x+0.2)
|> List.sum

sales
|> List.filter (fun flavor -> flavor = "dream cream")
|> List.length

