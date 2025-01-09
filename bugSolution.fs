let x = 10
let y = 20

let add x y = 
    let newX = x + y
    (newX, y)

let (resultX, resultY) = add x y
printf "%d %d" resultX resultY