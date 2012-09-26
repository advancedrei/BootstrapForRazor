[Bootstrap Extensions for ASP.NET Razor](http://github.com/AdvancedREI/BootstrapForRazor)
=================

Bootstrap is a sleek, intuitive, and powerful front-end framework for faster and easier web development, created and maintained by [Mark Otto](http://twitter.com/mdo) and [Jacob Thornton](http://twitter.com/fat) at Twitter.

To get started, checkout http://getbootstrap.com!


Bootstrap for ASP.NET Razor is a library of `@Html` extensions for the Razor parser that outputs form controls in the particular way that Bootstrap requires for the styles to line up and the validation to work properly.


Quick start
-----------

Install the NuGet package: `Install-Package BootstrapForRazor2`, clone the repo: `git clone git://github.com/advancedrei/bootstrapforrazor.git`, or  [download the latest release](https://github.com/advancedrei/bootstrapforrazor/zipball/master).

Once installed, add `@import AdvancedREI.Web.Bootstrap` to the top of your .cshtml file, and then you'll get to use the following commands:


- `@Html.BootstrapCheckBox()`
- `@Html.BootstrapInlineCheckBox()`
- `@Html.BootstrapCheckBoxFor()`
- `@Html.BootstrapInlineCheckboxFor()`
- `@Html.BootstrapCheckBoxListFor()`
- `@Html.BootstrapInlineCheckBoxListFor()`
- `@Html.BootstrapRadioButton()`
- `@Html.BootstrapRadioButtonListFor()`
- `@Html.BootstrapInlineRadioButtonListFor()`
- `@Html.BootstrapLabel()`
- `@Html.BootstrapLabelFor()`
- `@Html.BootstrapIconLabelFor()`

More commands will be added in the future.

Example:

        <div class="row-fluid">
            <div class="control-group span6">
                @Html.BootstrapLabel("RoleId")
                <div class="controls">
                    @Html.DropDownList("RoleId")
                    @Html.ValidationMessageFor(model => model.RoleId)
                </div>
            </div>

            <div class="control-group span6">
                @Html.BootstrapLabelFor(model => model.FirstName)
                <div class="controls">
                    @Html.TextBoxFor(model => model.FirstName, new { @class = "span5" })
                    @Html.ValidationMessageFor(model => model.FirstName)
                </div>
            </div>
        </div>

Bug tracker
-----------

Have a bug? Please create an issue here on GitHub that conforms with [necolas's guidelines](https://github.com/necolas/issue-guidelines).

https://github.com/AdvancedREI/BootstrapForRazor/issues



Twitter account
---------------

Keep up to date on announcements and more by following AdvancedREI on Twitter, [@AdvancedREI](http://twitter.com/AdvancedREI).



Blog
----

Read more detailed announcements, discussions, and more on [The AdvancedREI Dev Blog](http://advancedrei.com/blogs/development).


Author
-------

**Robert McLaws**

+ http://twitter.com/robertmclaws
+ http://github.com/advancedrei


Copyright and license
---------------------

Copyright 2012 AdvancedREI, LLC, and Twitter, Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this work except in compliance with the License.
You may obtain a copy of the License in the LICENSE file, or at:

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

The CheckBoxList and RadioButtonList are stripped-down and simplified variations on the 
[MvcCheckBoxList] (http://mvccbl.azurewebsites.net/) project, which you can also find on [GitHub] (https://github.com/mikhail-tsennykh/MVC3-Html.CheckBoxList-custom-extension). That project is licensed under the CodeProject Open License.