namespace f_lib.test

open NUnit.Framework
open f_lib.Say

[<TestFixture>]
type SayTests () =
    
    [<DefaultValue>]
    val mutable h: string -> int
    
    [<SetUp>]
    member public this.Setup () =
        this.h <- hello

    [<Test>]
    member public this.Hello_Returns42 () =
        Assert.That(this.h "Wombat", Is.EqualTo(42))
        