## Your Name:

# CIDM 3312 Lab 4: Model Binding

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
3. The website at https://www.paypalobjects.com/en_AU/vhelp/paypalmanager_help/credit_card_numbers.htm has sample credit card numbers. Verify that your validation rules work properly.
4. Open your razor page (.cshtml file) and add the proper `asp-for` tag helpers.
5. Also within your razor page, add the proper HTML code for validation.
6.	Bring in the JS code to perform the validation. At the bottom of your razor page add the following:
```
@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
```

## Task 4: Add Thank You Message


## Submit your assignment. You are now finished with Lab 4       