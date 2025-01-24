let swap x y = (y, x)

let a = 10
let b = 20
let (c,d) = swap a b
printf "%d %d" c d //This will print 20 10 as expected

let add2 x y = x + y
printf "%d" (add2 10 20) //This works fine now