let isPalindrome n =
  let arr' = (string n).ToCharArray()
  Array.rev arr' = arr'

[ for x in 111..999 do
  for y in 111..999 do
  yield x * y ]
|> List.filter isPalindrome
|> List.max |> printf "%d"