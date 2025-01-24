let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

let swap2 x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let a = 10
let b = 20
let (c,d) = swap2 a b
printf "%d %d" c d //this will print 20 10 as expected

let rec factorial n =
    if n = 0 then 1
    else n * factorial (n-1)

printf "%d" (factorial 5) //This works fine

let rec factorial2 n = 
    match n with
    | 0 -> 1
    | _ -> n * factorial2 (n-1)

printf "%d" (factorial2 5) //This works fine

let add x y = x + y
printf "%d" (add 10 20) //This works fine

let add2 x y = 
    match x,y with
    | a,b -> a+b

printf "%d" (add2 10 20) //This will not work. It will complain that add2 is not applied to any arguments