module f_lib.Vortex

let Vortex arg =
    if arg % 2 = 0 then arg / 2 else (arg * 3 + 1) / 2
    
let (|StopppingTime|) arg =
    let mutable borg = arg
    let mutable steps = 0
    while borg <> 1 do
        borg <- Vortex borg
        steps <- steps + 1
    steps
    
let CountSteps (StopppingTime x) = x
