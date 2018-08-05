Mutable
let mutable a = 10
a <- 4

let items = [1..5]
List.append items [6]
items

let prefix prefixStr baseStr =
    prefixStr + " , " + baseStr
prefix "Hello" "David" ;;

let exclaim s =
    s + "!"
 

let names = ["David" ; "Adam" ; "Alfie"]
names
|> Seq.map (prefix "Hello")
|> Seq.map (exclaim)
|> Seq.sort

let prefixwithhello = prefix "Hello" 
let saybighello = prefixwithhello >> exclaim

names
|> Seq.map saybighello
|> Seq.sort

names
|> Seq.map (fun x -> printfn "Mapped over %s" x; saybighello x)
|> Seq.sort

let hellos =
    names
    |> Seq.map (fun x -> printfn "Mapped over %s" x; saybighello x)
    |> Seq.sort
hellos
let hellos =
    names
    |> Seq.map (fun x -> printfn "Mapped over %s" x; saybighello x)
    |> Seq.sort
    |> Seq.iter (printfn "%s")
hellos