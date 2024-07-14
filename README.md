## Your Name: LAB 4 SOLUTION

# CIDM 3312 Lab 4: Model Binding

In this lab exercise you will create a razor page with a form and perform data validation. The ThoughtTronix company wants a web page where users can subscribe to their **MindSync Premium** service. MindSync devices are identified through a unique serial number in the range of 1,000 to 99,999. Create a razor page with the appropriate form that also reads in a credit card number to process the subscription fee. Display a thank you message after a successful submission.

## Task 0: Prepare Your Environment

1. Create an ASP.NET Core Project using the `dotnet new webapp` command.

## Task 1: Make a Razor Page with a Form

1. Create a new razor page named `Order.cshtml` in your project (you don't need a page model yet).
2. Make your razor page look like the following:

![Image of webpage](https://i.imgur.com/OPfnFU4.png)

  - Add an `<h3></h3>` tag with the text "MindSync Premium Subscription" inside.
  - Underneath that, use a `<p></p>` tag to display the sentences before the form.
  - Create an HTML/Bootstrap form that uses HTTP post. Use `<label>` and `<input>` tags for the Name, Serial Number, and Credit card number.

## Task 2: Make the Page Model
1. Create a Page Model (.cshtml.cs file) for your Razor Page. Remember the template code to place in a page model? Refer to `Index.cshtml.cs` or our lessons.
   * Don't forget to change the class name to match the name of your Razor Page.
   * Connect the Razor Page to the Page Model with the `@model` keyword.
2. Create an empty `OnPost()` method. This method will be called when you hit Submit on your form.
3. Create properties for each form element. You should create a Name, SerialNumber, and CreditCard property. Name and CreditCard should be `string` and SerialNumber should be `int`.
4. Add the `[BindProperty]` decorators to your properties. It is this line of code that sets up the model binding. Your code should look like this:

```
[BindProperty]
public string Name {get; set;} = string.Empty;
```

## Task 3: Add Data Validation
1. Add data validation rules to the properties.
   - Name does not need any specific data validation rules.
   - CreditCard should be validated as a credit card and the display name should be "Credit card number".
   - SerialNumber should require a range between 1,000 - 99,999 and displayed as "Serial Number".
2. Credit Card validation requires one more JS file imported. Open `Pages\Shared\_ValidationScriptsPartial.cshtml` and add this line:
```
<script src="~/lib/jquery-validation/dist/additional-methods.min.js"></script>
```
3. Open your razor page (.cshtml file) and add the proper `asp-for` tag helpers.
4. Delete any text in between your `<label></label>` tags. This is the actual text label like Name, Serial Number, or Credit card number. ASP.NET Core should fill in the label for you based on your data validation rules.
5. Also within your razor page, add the proper HTML code for validation. Add this code for each form element. For the name, the code will look like this:
```
    <span asp-validation-for="Name" class="text-danger"></span>
```
6. Add a data validation summary `<div>` at the top of the form like this:
```
    <!-- Display Data Validation Summary of all errors. Optional -->
    <div asp-validation-summary="All" class="text-danger"></div>
```
7. Bring in the JS code to perform the validation. At the bottom of your razor page add the following:
```
@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
```
8. The website at https://www.paypalobjects.com/en_AU/vhelp/paypalmanager_help/credit_card_numbers.htm has sample credit card numbers. Verify that your validation rules work properly.
9. This image shows how the web page should look with data validation errors:

![Image of errors](https://i.imgur.com/rxL6EMG.png)

## Task 4: Add Thank You Message
1. After the form, add HTML/Razor Page code that displays a thank you message when the user successfully submits the form. The message should say "Thank you {Name} for purchasing the ad-free tier for your MindSync with Serial Number #{SerialNumber}.".
2. Ensure that the thank you message only displays after the user successfully submits it the form. It should not display otherwise.
3. Add a link to your razor page in the navigation menu of the web site by adding the correct HTML code to Pages\Shared_Layout.cshtml.
4. Your final web page after form submission should look like this image:

![Image of form](https://i.imgur.com/i8P6Yzm.png)

## Submit your assignment. You are now finished with Lab 4       