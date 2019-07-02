let isDividedByAll n = Seq.forall (fun x -> n % x = 0)

let numbers = [|2..20|]
let max = Array.max(numbers)

Seq.unfold (fun x -> Some(x, x + max)) max
|> Seq.filter (fun x -> isDividedByAll x numbers)
|> Seq.head |> printf "%d"