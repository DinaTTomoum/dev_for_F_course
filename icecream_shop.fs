let icereamShop: string = "Karlos Parlor"
open System.Net
open System.Security.Claims
type SpecialFlavor = 
    |   Redrising
    |   Dreamcream

type Flavor =
    |   Strawberry
    |   Vanilla 
    |   Special of SpecialFlavor

let priceforFlavors flavor =
    match flavor with
    |   Strawberry ->
            1.1
    |   Vanilla ->
            0.9
    |   Special special ->
        match special with
        |   Redrising ->
                1.1
        |   Dreamcream ->
                0.9
    

// map all the items in the list below to their price
// map all the items in the list below to their price
// list.map takes 2 parameters to produce 3rd parameter. 2nd paramter is the list. 1st parameter is a function, which is usually called first class citizens.
// then add to know the full revenue from the sale of the items

let sales = 
    [
        Special Redrising
        Special Dreamcream
        Special Redrising
        Special Redrising
        Special Dreamcream
        Strawberry
        Strawberry
    ]


sales
|> List.map priceforFlavors
|> List.sum

sales
|> List.filter (fun Flavor -> Flavor = Strawberry)
|> List.length
|> List.map priceforFlavors
|> List.map (fun x -> x+0.2)
|> List.sum



