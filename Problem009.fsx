seq {
  for a in 1..1000 do
  for b in 1..1000 do
  for c in 1..1000 do
  if a + b + c = 1000 then
    yield (a, b, c) }
|> Seq.filter (fun (x, y, z) -> 
  (pown x 2 + pown y 2 = pown z 2) && x < y && y < z)
|> Seq.head |> (fun (x, y, z) -> x * y * z)
|> printf "%d"