## Intro

This assignment is a very small task to create a VAT calculator.

For reference, Gross Amount is calculated as follows:

`[Net Amount] * (1 + ([TaxRate] / 100)`

- This assignment takes an average of about 60 minutes.
- Use Bootstrap in your views to make it responsive.
- Use async await as you see fit.
- We used MSTest and [Moq](http://code.google.com/p/moq) at MKopa, references have been added using [NuGet](http://nuget.codeplex.com/) Packages. Everything is in place for you to just write the code (no "File > New Project" required).
- Please DO NOT fork this project on Github, as we want to be sure candidates' test submissions are original.

## Task requirements

- All stories to be completed with an appropriate level of testing.
- No actual database implementation is required, feel free to stub it out.
- Your code should trend towards being SOLID.
- Please [download](https://github.com/mKopadev/RecruitmentMVCTest/archives/master) the [Recruitment-Test repository](https://github.com/mkopadev/RecruitmentMVCTest), complete the tasks as you see fit.
- Send us a Dropbox/Skydrive/whatever link to your zipped code to softwareapps@m-kopa.com or attach a zip file directly to the email.

## Task Stories

Please complete each story in order.

---

### Story 1

As a **user**  
I want **to see the gross amount calculated based on current rate of tax**  
So that **I know the total amount is due**

#### Acceptance criteria

- Standard Rate of Tax is 20%.
- User should be able to type in Net Amount.
- Supported by unit tests.

---

### Story 2

As a **site administrator**  
I want **to be able to change the tax rates**  
So that **I don't need to change the code when the tax rate changes**

#### Acceptance criteria

- Current Tax Rate is retrieved from data store.
- Gross amount is calculated based on the current amount in the data store.

---

### Story 3

As a **user**  
I want **to see my gross amount rounded correctly to 2 decimal places**  
So that **I'm not confused about how much I owe in total**

#### Acceptance criteria

- Gross amount correctly rounded to 2 decimal places (1.316 should round to 1.32).

---

### Story 4

As an **supermarket**  
I want **to be able to calculate gross amount based on applicable tax rate**  
So that **people will pay the correct amount of tax based on their purchase**

#### Acceptance criteria

- 20% tax for "Computer Games".
- 5% tax for "Children's Clothing".
- No tax for everything else.

---

This test was inspired by the JustGiving Recruitment Test which you can find [here](https://github.com/JustGiving/Recruitment-Test), big shout out goes out to them.

Thanks for your time, looking forward to seeing your answers.


