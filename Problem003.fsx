let factorize n =
  let sqrt' = (float >> sqrt >> int64) n
  [2L..sqrt']
  |> List.filter (fun x -> n % x = 0L)

let isPrime n = factorize n |> List.length = 0

factorize 600851475143L
|> List.filter isPrime
|> List.max
|> printf "%d"