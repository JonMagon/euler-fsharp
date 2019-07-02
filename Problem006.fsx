let list' = [1..100]
let sumOfSqr = List.map (fun x -> pown x 2) list' |> List.sum
let sqrOfSum = pown (List.sum list') 2

printf "%d" (sqrOfSum - sumOfSqr)