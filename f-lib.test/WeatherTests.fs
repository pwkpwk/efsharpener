namespace f_lib.test

open NUnit.Framework

[<TestFixture>]
type WeatherTests() =
    [<DefaultValue>]
    val mutable weather: c_lib.Weather

    [<SetUp>]
    member public self.SetUpTest() =
        self.weather <- c_lib.Weather(true)

    [<TearDown>]
    member public self.TearDown() = self.weather <- null

    [<Test>]
    member public this.BasicTest() =
        Assert.That(this.weather.IsNice, Is.True)

    [<TestCase(true, ExpectedResult = true)>]
    [<TestCase(false, ExpectedResult = false)>]
    member public this.NewWeather_CorrectSetup(nice: bool) = c_lib.Weather(nice).IsNice

    [<TestCase(arguments = [| true; false |], ExpectedResult = true)>]
    [<TestCase(arguments = [| false; true |], ExpectedResult = true)>]
    [<TestCase(arguments = [| true; true |], ExpectedResult = false)>]
    [<TestCase(arguments = [| false; false |], ExpectedResult = false)>]
    member public this.ChangeWeather_ReturnsChangeStatue(init: bool, changeTo: bool) =
        c_lib.Weather(init).Change changeTo
