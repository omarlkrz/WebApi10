#pragma checksum "\\sv-don\etudiantsFC$\O.Lakrouz\Documents\Mise en oeuvre d un projet\GitProjects\Projet2\projet-GitHub\Views\Valider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa53cf177514c58e6b3781457f19a4d1785604f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Valider_Index), @"mvc.1.0.view", @"/Views/Valider/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Valider/Index.cshtml", typeof(AspNetCore.Views_Valider_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "\\sv-don\etudiantsFC$\O.Lakrouz\Documents\Mise en oeuvre d un projet\GitProjects\Projet2\projet-GitHub\Views\_ViewImports.cshtml"
using WebApi10;

#line default
#line hidden
#line 2 "\\sv-don\etudiantsFC$\O.Lakrouz\Documents\Mise en oeuvre d un projet\GitProjects\Projet2\projet-GitHub\Views\_ViewImports.cshtml"
using WebApi10.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa53cf177514c58e6b3781457f19a4d1785604f3", @"/Views/Valider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecd81140eaeb8243c8f1ce7e457341710c44fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Valider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "\\sv-don\etudiantsFC$\O.Lakrouz\Documents\Mise en oeuvre d un projet\GitProjects\Projet2\projet-GitHub\Views\Valider\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutGeneral.cshtml";

#line default
#line hidden
            BeginContext(97, 5023, true);
            WriteLiteral(@"
<script>
    getEquipments();

</script>

<<!-- navbar navbar-inverse /////////////////////////////////////////////////////////////////// -->
<div class=""container body-content"">

    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""col-md-12"">

                <ul class=""titleModel"">
                    <p>Validation d'inventaire</p>
                </ul>
            </div>

            <div class=""col-md-12"">

                <ul class=""list-group"">
                    <h5 class=""list-group-item list-group-item-heading-leftSide"">OPTIONS</h5>
                    <li class=""list-group-item list-group-item-info"">Créer un modèle</li>
                    <li class=""list-group-item list-group-item-info"">Ajouter un équipement</li>
                    <li class=""list-group-item list-group-item-info"">Retirer un équipement</li>

                </ul>



            </div>
        </div>
        <div class=""col-md-9"">

            <div class=""panel panel-defau");
            WriteLiteral(@"lt"">
                <!-- Default panel contents -->
                <div class=""list-group-item-heading"">Équipement correctement détecté</div>

                <!-- Table -->
                <table class=""table"">
                    <tr>
                        <th></th>
                        <th>Type</th>
                        <th>Modèle</th>
                        <th>Fabricant</th>
                        <th>No. de série</th>
                        <th>No. inventaire</th>

                    </tr>
                    <tbody id=""idTBodyCorrect"">
                        <tr>
                            <td>
                                <span class=""input-group-addon"">
                                    <input type=""checkbox"" aria-label=""..."">
                                </span>
                            </td>
                            <td>Moniteur</td>
                            <td>LD17B303</td>
                            <td>Toshiba</td>
                     ");
            WriteLiteral(@"       <td>09MYG22N0122</td>
                            <td>6553</td>

                        </tr>
                        <tr>
                            <td>
                                <span class=""input-group-addon"">
                                    <input type=""checkbox"" aria-label=""..."">
                                </span>
                            </td>
                            <td>Moniteur</td>
                            <td>LD17B303</td>
                            <td>Toshiba</td>
                            <td>09MYG22N0122</td>
                            <td>6553</td>

                        </tr>
                        <tr>
                            <td>
                                <span class=""input-group-addon"">
                                    <input type=""checkbox"" aria-label=""..."">
                                </span>
                            </td>
                            <td>Moniteur</td>
                            <td>LD17");
            WriteLiteral(@"B303</td>
                            <td>Toshiba</td>
                            <td>09MYG22N0122</td>
                            <td>6553</td>

                    </tbody>


                </table>

                <div class=""list-group-item-heading btn-bg"">
                    <a href=""#"" class=""btn-ajuster btn btn-default"" role=""button"">Enregistrer</a>&nbsp;
                </div>


            </div>

            <div class=""panel panel-default"">
                <!-- Default panel contents -->
                <div class=""list-group-item-heading"">Équipement détecté sans numéro de Série</div>

                <!-- Table -->
                <table class=""table"">
                    <tr>
                        <th></th>
                        <th>Type</th>
                        <th>Modèle</th>
                        <th>Fabricant</th>
                        <th>No. de série</th>
                        <th>No. inventaire</th>

                    </tr>
             ");
            WriteLiteral(@"       <tbody id=""idTBodyIncorrect"">
                        <tr>
                            <td>
                                <span class=""input-group-addon"">
                                    <input type=""checkbox"" aria-label=""..."">
                                </span>
                            </td>
                            <td>Moniteur</td>
                            <td>LD17B303</td>
                            <td>Toshiba</td>
                            <td></td>
                            <td>6553</td>
                        </tr>
                    </tbody>
                </table>

                <div class=""list-group-item-heading btn-bg"">
                    <a href=""#"" class=""btn-ajuster btn btn-default"" role=""button"">Enregistrer</a>&nbsp;
                </div>

            </div>

        </div>

    </div>

    <hr />
    <footer></footer>
</div>


");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591