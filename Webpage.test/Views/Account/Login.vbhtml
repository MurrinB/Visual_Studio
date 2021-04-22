
@Code
    ViewBag.Title = "Welcome"
End Code

<h2>@ViewBag.Title.</h2>
<head>
    <link rel="stylesheet" type="text/css" href="~/Content/general_styles.css" />
</head>
<div class="row">
    <section class="col-md-8">
        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                @Html.AntiForgeryToken()
                @<text>
                <h4>One of my favorite songs, from my all time favorite show!</h4>
                <hr />
              <div class="video">
                  <iframe src="https://www.youtube.com/embed/208SiwbYrsc" width="750" height="550"></iframe>
              </div>

            


              <div class="javaAni">
                  <p>
                      <button class="btn" onclick="boxMove()">Click Here</button>
                  </p>
                  <div id="ani_container">
                      <div id="animation"></div>
                  </div>
                  <script src="~/Scripts/app/small_animation.js"></script>
              </div>
           
                
   
                @* Enable this once you have account confirmation enabled for password reset functionality
                    <p>
                        @Html.ActionLink("Forgot your password?", "ForgotPassword")
                    </p>*@
                </text>
            End Using
        </section>
    </section>
    </div>
    <div class="col-md-4">
        <section id="socialLoginForm">
            @Html.Partial("_ExternalLoginsListPartial", New ExternalLoginListViewModel With {.ReturnUrl = ViewBag.ReturnUrl})
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
