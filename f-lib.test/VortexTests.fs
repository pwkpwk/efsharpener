module f_lib.test.VortexTests

open NUnit.Framework
open f_lib.Vortex

[<TestFixture>]
type VortexTests() =

    [<SetUp>]
    member public self.SetUpTest() =
        for StopppingTime n in 10..12 do
            printf $"{n} "

    [<Test>]
    member public self.CollatzTest() =
        Assert.That(CountSteps 100, Is.GreaterThan(1))

    [<TestCase(0.01, 0.001, ExpectedResult = false)>]
    [<TestCase(0.01, 0.010_000_01, ExpectedResult = true)>]
    member public self.CloseEnoughTest(x: float, y: float) = CloseEnough x y
