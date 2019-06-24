let rec fib a b = a::(if b < 4 * (pown 10 6) then fib b (a + b) else [])
printf "%d" (fib 1 2 |> List.filter (fun x -> x % 2 = 0) |> List.sum)