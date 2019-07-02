let isPrime n  =
  let sqrt' = (float >> sqrt >> int) n
  [2..sqrt']
  |> Seq.forall (fun x -> n % x <> 0)

Seq.unfold (fun x -> Some(x, x + 2)) 3
|> Seq.filter (fun x -> isPrime x)
|> Seq.take (10001 - 1) |> Seq.last |> printf "%d"