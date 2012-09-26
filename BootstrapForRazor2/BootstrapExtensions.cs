using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace AdvancedREI.Web.Bootstrap
{
    public static class BootstrapExtensions
    {

        #region Properties

        /// <summary>
        /// Counter to be used on a label linked to each checkbox in the list
        /// </summary>
        private static int LabelCounter { get; set; }

        #endregion

        #region Methods

        #region Constructor

        static BootstrapExtensions()
        {
            LabelCounter = 0;
        }

        #endregion

        #region CheckBoxFor


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapCheckBoxFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            bool isChecked = false;
            if (metadata.Model != null)
            {
                bool modelChecked;
                if (Boolean.TryParse(metadata.Model.ToString(), out modelChecked))
                {
                    isChecked = modelChecked;
                }
            }
            var text = ExpressionHelper.GetExpressionText(expression);
            return MvcHtmlString.Create(htmlHelper.BootstrapInputInternal(metadata, InputType.CheckBox, text, metadata.DisplayName, "true", isChecked, "checkbox", HtmlHelper.AnonymousObjectToHtmlAttributes(null)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapInlineCheckBoxFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            bool isChecked = false;
            if (metadata.Model != null)
            {
                bool modelChecked;
                if (Boolean.TryParse(metadata.Model.ToString(), out modelChecked))
                {
                    isChecked = modelChecked;
                }
            }

            var text = ExpressionHelper.GetExpressionText(expression);
            return MvcHtmlString.Create(htmlHelper.BootstrapInputInternal(metadata, InputType.CheckBox, text, metadata.DisplayName, "true", isChecked, "checkbox inline", HtmlHelper.AnonymousObjectToHtmlAttributes(null)));
        }

        #endregion

        #region CheckBox

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapCheckBox(this HtmlHelper htmlHelper, string name, string displayText)
        {
            return BootstrapCheckBox(htmlHelper, name, "true", displayText, false, (object)null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="displayText">The text to display.</param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapCheckBox(this HtmlHelper htmlHelper, string name, string value, string displayText)
        {
            return BootstrapCheckBox(htmlHelper, name, value, displayText, false, (object)null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="displayText"></param>
        /// <param name="isChecked"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapCheckBox(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked)
        {
            return BootstrapCheckBox(htmlHelper, name, value, displayText, isChecked, (object)null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="displayText"></param>
        /// <param name="isChecked"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapCheckBox(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked, object htmlAttributes)
        {
            return BootstrapCheckBox(htmlHelper, name, value, displayText, isChecked, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="displayText"></param>
        /// <param name="isChecked"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapCheckBox(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked, IDictionary<string, object> htmlAttributes)
        {
            ModelMetadata metadata = (ModelMetadata)null;
            return MvcHtmlString.Create(htmlHelper.BootstrapInputInternal(metadata, InputType.CheckBox, name, displayText, value, isChecked, "checkbox", htmlAttributes));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapInlineCheckBox(this HtmlHelper htmlHelper, string name, string displayText)
        {
            return BootstrapInlineCheckBox(htmlHelper, name, "true", displayText, false, (object)null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="displayText"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapInlineCheckBox(this HtmlHelper htmlHelper, string name, string value, string displayText)
        {
            return BootstrapInlineCheckBox(htmlHelper, name, value, displayText, false, (object)null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="displayText"></param>
        /// <param name="isChecked"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapInlineCheckBox(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked)
        {
            return BootstrapInlineCheckBox(htmlHelper, name, value, displayText, isChecked, (object)null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="displayText"></param>
        /// <param name="isChecked"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapInlineCheckBox(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked, object htmlAttributes)
        {
            return BootstrapInlineCheckBox(htmlHelper, name, value, displayText, isChecked, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="displayText"></param>
        /// <param name="isChecked"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapInlineCheckBox(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked, IDictionary<string, object> htmlAttributes)
        {
            ModelMetadata metadata = (ModelMetadata)null;
            return MvcHtmlString.Create(htmlHelper.BootstrapInputInternal(metadata, InputType.CheckBox, name, displayText, value, isChecked, "checkbox inline", htmlAttributes));
        }

        #endregion

        #region CheckBoxList

        /// <summary>
        /// Model-Based function (For...)
        /// </summary>
        /// <typeparam name="TModel">Current ViewModel</typeparam>
        /// <typeparam name="TItem">ViewModel Item</typeparam>
        /// <typeparam name="TValue">ViewModel Item type of the value</typeparam>
        /// <typeparam name="TKey">ViewModel Item type of the key</typeparam>
        /// <typeparam name="TProperty">ViewModel property</typeparam>
        /// <param name="htmlHelper">MVC Html helper class that is being extended</param>
        /// <param name="listNameExpr">ViewModel Item type to serve as a name of each checkbox in a list (use this name to POST list values array back to the controller)</param>
        /// <param name="sourceDataExpr">Data list to be used as a source for the list (set in viewmodel)</param>
        /// <param name="valueExpr">Data list value type to be used as checkbox 'Value'</param>
        /// <param name="textToDisplayExpr">Data list value type to be used as checkbox 'Text'</param>
        /// <param name="selectedValuesExpr">Data list of selected items (should be of same data type as a source list)</param>
        /// <param name="htmlAttributesExpr">Data list HTML tag attributes for each checkbox</param>
        /// <returns>HTML string containing checkbox list</returns>
        public static MvcHtmlString BootstrapCheckBoxListFor<TModel, TProperty, TItem, TValue, TKey>
            (this HtmlHelper<TModel> htmlHelper,
             Expression<Func<TModel, TProperty>> listNameExpr,
             Expression<Func<TModel, IEnumerable<TItem>>> sourceDataExpr,
             Expression<Func<TItem, TValue>> valueExpr,
             Expression<Func<TItem, TKey>> textToDisplayExpr,
             Expression<Func<TModel, IEnumerable<TItem>>> selectedValuesExpr,
             IDictionary<string, object> htmlAttributes = null)
        {
            var modelMetadata = ModelMetadata.FromLambdaExpression(listNameExpr, htmlHelper.ViewData);
            return BootstrapInputList(htmlHelper, modelMetadata, listNameExpr.ToProperty(), InputType.CheckBox, sourceDataExpr, valueExpr,
                 textToDisplayExpr, selectedValuesExpr, "checkbox", htmlAttributes);
        }

        /// <summary>
        /// Model-Based function (For...)
        /// </summary>
        /// <typeparam name="TModel">Current ViewModel</typeparam>
        /// <typeparam name="TItem">ViewModel Item</typeparam>
        /// <typeparam name="TValue">ViewModel Item type of the value</typeparam>
        /// <typeparam name="TKey">ViewModel Item type of the key</typeparam>
        /// <typeparam name="TProperty">ViewModel property</typeparam>
        /// <param name="htmlHelper">MVC Html helper class that is being extended</param>
        /// <param name="listNameExpr">ViewModel Item type to serve as a name of each checkbox in a list (use this name to POST list values array back to the controller)</param>
        /// <param name="sourceDataExpr">Data list to be used as a source for the list (set in viewmodel)</param>
        /// <param name="valueExpr">Data list value type to be used as checkbox 'Value'</param>
        /// <param name="textToDisplayExpr">Data list value type to be used as checkbox 'Text'</param>
        /// <param name="selectedValuesExpr">Data list of selected items (should be of same data type as a source list)</param>
        /// <param name="htmlAttributesExpr">Data list HTML tag attributes for each checkbox</param>
        /// <returns>HTML string containing checkbox list</returns>
        public static MvcHtmlString BootstrapInlineCheckBoxListFor<TModel, TProperty, TItem, TValue, TKey>
            (this HtmlHelper<TModel> htmlHelper,
             Expression<Func<TModel, TProperty>> listNameExpr,
             Expression<Func<TModel, IEnumerable<TItem>>> sourceDataExpr,
             Expression<Func<TItem, TValue>> valueExpr,
             Expression<Func<TItem, TKey>> textToDisplayExpr,
             Expression<Func<TModel, IEnumerable<TItem>>> selectedValuesExpr,
             IDictionary<string, object> htmlAttributes = null)
        {
            var modelMetadata = ModelMetadata.FromLambdaExpression(listNameExpr, htmlHelper.ViewData);
            return BootstrapInputList(htmlHelper, modelMetadata, listNameExpr.ToProperty(), InputType.CheckBox, sourceDataExpr, valueExpr,
                 textToDisplayExpr, selectedValuesExpr, "checkbox inline", htmlAttributes);
        }

        #endregion

        #region RadioButton

        public static MvcHtmlString BootstrapRadioButton(this HtmlHelper htmlHelper, string name, string value, string displayText)
        {
            return BootstrapRadioButton(htmlHelper, name, value, displayText, false, (object)null);
        }

        public static MvcHtmlString BootstrapRadioButton(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked)
        {
            return BootstrapRadioButton(htmlHelper, name, value, displayText, isChecked, (object)null);
        }

        public static MvcHtmlString BootstrapRadioButton(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked, object htmlAttributes)
        {
            return BootstrapRadioButton(htmlHelper, name, value, displayText, isChecked, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString BootstrapRadioButton(this HtmlHelper htmlHelper, string name, string value, string displayText, bool isChecked, IDictionary<string, object> htmlAttributes)
        {
            ModelMetadata metadata = (ModelMetadata)null;
            return MvcHtmlString.Create(htmlHelper.BootstrapInputInternal(metadata, InputType.Radio, name, displayText, value, isChecked, "radio", htmlAttributes));
        }

        #endregion

        #region RadioButtonList

        /// <summary>
        /// Model-Based function (For...)
        /// </summary>
        /// <typeparam name="TModel">Current ViewModel</typeparam>
        /// <typeparam name="TItem">ViewModel Item</typeparam>
        /// <typeparam name="TValue">ViewModel Item type of the value</typeparam>
        /// <typeparam name="TKey">ViewModel Item type of the key</typeparam>
        /// <typeparam name="TProperty">ViewModel property</typeparam>
        /// <param name="htmlHelper">MVC Html helper class that is being extended</param>
        /// <param name="listNameExpr">ViewModel Item type to serve as a name of each checkbox in a list (use this name to POST list values array back to the controller)</param>
        /// <param name="sourceDataExpr">Data list to be used as a source for the list (set in viewmodel)</param>
        /// <param name="valueExpr">Data list value type to be used as checkbox 'Value'</param>
        /// <param name="textToDisplayExpr">Data list value type to be used as checkbox 'Text'</param>
        /// <param name="selectedValuesExpr">Data list of selected items (should be of same data type as a source list)</param>
        /// <param name="htmlAttributesExpr">Data list HTML tag attributes for each checkbox</param>
        /// <returns>HTML string containing checkbox list</returns>
        public static MvcHtmlString BootstrapRadioButtonListFor<TModel, TProperty, TItem, TValue, TKey>
            (this HtmlHelper<TModel> htmlHelper,
             Expression<Func<TModel, TProperty>> listNameExpr,
             Expression<Func<TModel, IEnumerable<TItem>>> sourceDataExpr,
             Expression<Func<TItem, TValue>> valueExpr,
             Expression<Func<TItem, TKey>> textToDisplayExpr,
             Expression<Func<TModel, IEnumerable<TItem>>> selectedValuesExpr,
             IDictionary<string, object> htmlAttributes = null)
        {
            var modelMetadata = ModelMetadata.FromLambdaExpression(listNameExpr, htmlHelper.ViewData);
            return BootstrapInputList(htmlHelper, modelMetadata, listNameExpr.ToProperty(), InputType.Radio, sourceDataExpr, valueExpr,
                 textToDisplayExpr, selectedValuesExpr, "radio", htmlAttributes);
        }

        /// <summary>
        /// Model-Based function (For...)
        /// </summary>
        /// <typeparam name="TModel">Current ViewModel</typeparam>
        /// <typeparam name="TItem">ViewModel Item</typeparam>
        /// <typeparam name="TValue">ViewModel Item type of the value</typeparam>
        /// <typeparam name="TKey">ViewModel Item type of the key</typeparam>
        /// <typeparam name="TProperty">ViewModel property</typeparam>
        /// <param name="htmlHelper">MVC Html helper class that is being extended</param>
        /// <param name="listNameExpr">ViewModel Item type to serve as a name of each checkbox in a list (use this name to POST list values array back to the controller)</param>
        /// <param name="sourceDataExpr">Data list to be used as a source for the list (set in viewmodel)</param>
        /// <param name="valueExpr">Data list value type to be used as checkbox 'Value'</param>
        /// <param name="textToDisplayExpr">Data list value type to be used as checkbox 'Text'</param>
        /// <param name="selectedValuesExpr">Data list of selected items (should be of same data type as a source list)</param>
        /// <param name="htmlAttributesExpr">Data list HTML tag attributes for each checkbox</param>
        /// <returns>HTML string containing checkbox list</returns>
        public static MvcHtmlString BootstrapInlineRadioButtonListFor<TModel, TProperty, TItem, TValue, TKey>
            (this HtmlHelper<TModel> htmlHelper,
             Expression<Func<TModel, TProperty>> listNameExpr,
             Expression<Func<TModel, IEnumerable<TItem>>> sourceDataExpr,
             Expression<Func<TItem, TValue>> valueExpr,
             Expression<Func<TItem, TKey>> textToDisplayExpr,
             Expression<Func<TModel, IEnumerable<TItem>>> selectedValuesExpr,
             IDictionary<string, object> htmlAttributes = null)
        {
            var modelMetadata = ModelMetadata.FromLambdaExpression(listNameExpr, htmlHelper.ViewData);
            return BootstrapInputList(htmlHelper, modelMetadata, listNameExpr.ToProperty(), InputType.Radio, sourceDataExpr, valueExpr,
                 textToDisplayExpr, selectedValuesExpr, "radio inline", htmlAttributes);
        }

        #endregion

        #region Labels

        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <param name="labelText"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapLabel(this HtmlHelper html, string labelText)
        {
            return html.Label(string.Empty, labelText, new { @class = "control-label" });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapLabelFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression)
        {
            return htmlHelper.LabelFor(expression, new {@class = "control-label"});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="iconName"></param>
        /// <returns></returns>
        public static MvcHtmlString BootstrapIconLabelFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, string iconName)
        {
            var icon = new TagBuilder("i");
            icon.AddCssClass(iconName);

            var modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);

            var label = new TagBuilder("label");
            label.AddCssClass("control-label");
            label.Attributes.Add("for", expression.ToProperty());

            label.InnerHtml = string.Format("{1}&nbsp;{0}", icon.ToString(TagRenderMode.Normal), modelMetadata.DisplayName);
            return MvcHtmlString.Create(label.ToString(TagRenderMode.Normal));
        }

        #endregion

        #endregion

        #region Private Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="metadata"></param>
        /// <param name="inputType"></param>
        /// <param name="name"></param>
        /// <param name="displayText"></param>
        /// <param name="value"></param>
        /// <param name="isChecked"></param>
        /// <param name="cssclass"></param>
        /// <returns></returns>
        private static string BootstrapInputInternal(this HtmlHelper htmlHelper, ModelMetadata metadata, InputType inputType, string name, string displayText, string value, bool isChecked, string cssclass, IDictionary<string, object> htmlAttributes)
        {
            var fullName = htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);

            var label = new TagBuilder("label");
            label.AddCssClass(cssclass);
            var checkbox = new TagBuilder("input");
            checkbox.MergeAttributes(htmlAttributes);

            if (isChecked)
            {
                checkbox.MergeAttribute("checked", "checked");
            }

            switch (inputType)
            {
                case InputType.CheckBox:
                    checkbox.MergeAttribute("type", "checkbox");
                    break;
                case InputType.Radio:
                    checkbox.MergeAttribute("type", "radio");
                    break;
            }
		    checkbox.MergeAttribute("value", value);
		    checkbox.MergeAttribute("name", fullName);

            // if there are any errors for a named field, we add the css attribute
            ModelState modelState;
            if (htmlHelper.ViewData.ModelState.TryGetValue(fullName, out modelState))
                if (modelState.Errors.Count > 0)
                    checkbox.AddCssClass(HtmlHelper.ValidationInputCssClassName);

            if (metadata != null)
            {
                checkbox.MergeAttributes(htmlHelper.GetUnobtrusiveValidationAttributes(name, metadata));
            }
            
            // create linked label tag
            var linkName = name + LabelCounter++;
            checkbox.GenerateId(linkName);

            label.MergeAttribute("for", linkName.Replace(".", "_"));
            label.InnerHtml = string.Format("{0}{1}", checkbox.ToString(TagRenderMode.Normal), displayText);

            return label.ToString(TagRenderMode.Normal);
        }

        /// <summary>
        /// Model-Based main function
        /// </summary>
        /// <typeparam name="TModel">Current ViewModel</typeparam>
        /// <typeparam name="TItem">ViewModel Item</typeparam>
        /// <typeparam name="TValue">ViewModel Item type of the value</typeparam>
        /// <typeparam name="TKey">ViewModel Item type of the key</typeparam>
        /// <param name="htmlHelper">MVC Html helper class that is being extended</param>
        /// <param name="modelMetadata">Model Metadata</param>
        /// <param name="inputType">The InputType to generate UI for.</param>
        /// <param name="listName">Name of each checkbox in a list (use this name to POST list values array back to the controller)</param>
        /// <param name="sourceDataExpr">Data list to be used as a source for the list (set in viewmodel)</param>
        /// <param name="valueExpr">Data list value type to be used as checkbox 'Value'</param>
        /// <param name="textToDisplayExpr">Data list value type to be used as checkbox 'Text'</param>
        /// <param name="selectedValuesExpr">Data list of selected items (should be of same data type as a source list)</param>
        /// <param name="cssClass"></param>
        /// <returns>HTML string containing checkbox list</returns>
        internal static MvcHtmlString BootstrapInputList<TModel, TItem, TValue, TKey>(HtmlHelper<TModel> htmlHelper,
            ModelMetadata modelMetadata,
            string listName,
            InputType inputType, 
            Expression<Func<TModel, IEnumerable<TItem>>> sourceDataExpr,
            Expression<Func<TItem, TValue>> valueExpr,
            Expression<Func<TItem, TKey>> textToDisplayExpr,
            Expression<Func<TModel, IEnumerable<TItem>>> selectedValuesExpr,
            string cssClass, IDictionary<string, object> htmlAttributes)
        {
            // validation
            if (sourceDataExpr == null || sourceDataExpr.Body.ToString() == "null") return MvcHtmlString.Create("");
            if (htmlHelper.ViewData.Model == null) throw new NoNullAllowedException("There is no Model in the ViewData.");
            if (string.IsNullOrEmpty(listName)) throw new ArgumentException("The name of the CheckBoxList cannot be null or empty.", "listName");

            // set properties
            var model = htmlHelper.ViewData.Model;
            var sourceData = sourceDataExpr.Compile()(model).ToList();
            var valueFunc = valueExpr.Compile();
            var textToDisplayFunc = textToDisplayExpr.Compile();
            var selectedItems = new List<TItem>();
            if (selectedValuesExpr != null)
            {
                var _selectedItems = selectedValuesExpr.Compile()(model);
                if (_selectedItems != null) selectedItems = _selectedItems.ToList();
            }
            var selectedValues = selectedItems.Select(s => s == null ? "" : valueFunc(s).ToString()).ToList();

            // validate source data
            if (!sourceData.Any()) return MvcHtmlString.Create("");

            // create checkbox list
            var sb = new StringBuilder();

            // create list of checkboxes based on data
            foreach (var item in sourceData)
            {
                // get checkbox value and text
                var itemValue = valueFunc(item).ToString();
                var itemText = textToDisplayFunc(item).ToString();

                // create checkbox element
                sb.Append(htmlHelper.BootstrapInputInternal(modelMetadata, inputType, listName, itemText, itemValue, selectedValues.Any(x => x == itemValue), cssClass, htmlAttributes));
            }
            return MvcHtmlString.Create(sb.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="propertyExpression"></param>
        /// <returns></returns>
        internal static string ToProperty<TModel, TItem>(this Expression<Func<TModel, TItem>> propertyExpression)
        {
            return ExpressionHelper.GetExpressionText(propertyExpression);
        }

        private static RouteValueDictionary ToRouteValueDictionary(IDictionary<string, object> dictionary)
        {
            return dictionary == null ? new RouteValueDictionary() : new RouteValueDictionary(dictionary);
        }


        #endregion

    }
}