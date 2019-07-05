Imports NUnit.Framework

<TestFixture>
Public Class SayTest
    <Test>
    Public Sub Zero()
        Assert.That(Say.InEnglish(0), [Is].EqualTo("zero"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub One()
        Assert.That(Say.InEnglish(1), [Is].EqualTo("one"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub Fourteen()
        Assert.That(Say.InEnglish(14), [Is].EqualTo("fourteen"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub Twenty()
        Assert.That(Say.InEnglish(20), [Is].EqualTo("twenty"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub Twenty_two()
        Assert.That(Say.InEnglish(22), [Is].EqualTo("twenty-two"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub Sixty_nine()
        Assert.That(Say.InEnglish(69), [Is].EqualTo("sixty-nine"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub OneHundred()
        Assert.That(Say.InEnglish(100), [Is].EqualTo("one hundred"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub OneHundredTwentyThree()
        Assert.That(Say.InEnglish(123), [Is].EqualTo("one hundred twenty-three"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub OneThousand()
        Assert.That(Say.InEnglish(1000), [Is].EqualTo("one thousand"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub OneThousandTwoHundredThirtyFour()
        Assert.That(Say.InEnglish(1234), [Is].EqualTo("one thousand two hundred thirty-four"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub OneMillion()
        Assert.That(Say.InEnglish(1000000), [Is].EqualTo("one million"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub OneMillionTwo()
        Assert.That(Say.InEnglish(1000002), [Is].EqualTo("one million two"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub OneMillionTwoThousandThreeHundredFortyFive()
        Assert.That(Say.InEnglish(1002345), [Is].EqualTo("one million two thousand three hundred forty-five"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub AReallyBigNumber()
        Assert.That(Say.InEnglish(987654321123), [Is].EqualTo("nine hundred eighty-seven billion six hundred fifty-four million three hundred twenty-one thousand one hundred twenty-three"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub BelowZero()
        Assert.That(Say.InEnglish(-1), [Is].EqualTo("Error: doesn't support negative number"))
    End Sub

    <Ignore("")>
    <Test>
    Public Sub OverOneTrillion()
        Assert.That(Say.InEnglish(1000000000000), [Is].EqualTo("Error: doesn't support number over one trillion"))
    End Sub
End Class
