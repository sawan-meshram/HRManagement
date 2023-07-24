<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Departments.aspx.cs" Inherits="HRManagement.Views.Employee.Departments" %>
<!DOCTYPE html>
<html lang="en" class="light-style layout-menu-fixed" dir="ltr" data-theme="theme-default" data-assets-path="/Content/assets/" data-template="vertical-menu-template-free">
  <head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0" />
    <title>Dashboard - Analytics | Sneat - Bootstrap 5 HTML Admin Template - Pro</title>
    <meta name="description" content="" />
    <!-- Favicon -->
    <link rel="icon" type="image/x-icon" href="/Content/assets/img/favicon/favicon.ico" />
    <!-- Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Public+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;1,300;1,400;1,500;1,600;1,700&display=swap" rel="stylesheet" />
    <!-- Icons. Uncomment required icon fonts -->
    <link rel="stylesheet" href="/Content/assets/vendor/fonts/boxicons.css" />
    <!-- Core CSS -->
    <link rel="stylesheet" href="/Content/assets/vendor/css/core.css" class="template-customizer-core-css" />
    <link rel="stylesheet" href="/Content/assets/vendor/css/theme-default.css" class="template-customizer-theme-css" />
    <link rel="stylesheet" href="/Content/assets/css/demo.css" />
    <!-- Vendors CSS -->
    <link rel="stylesheet" href="/Content/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.css" />
    <link rel="stylesheet" href="/Content/assets/vendor/libs/apex-charts/apex-charts.css" />

    <link rel="stylesheet" href="https://cdn.datatables.net/1.13.5/css/dataTables.bootstrap5.min.css" />

    <!-- Page CSS -->
    <!-- Helpers -->
    <script src="/Content/assets/vendor/js/helpers.js"></script>
    <!--! Template customizer & Theme config files MUST be included after core stylesheets and helpers.js in the <head> section -->
    <!--? Config:  Mandatory theme config file contain global vars & default theme options, Set your preferred theme option in this file.  -->
    <script src="/Content/assets/js/config.js"></script>
  </head>
  <body>
    <!-- Layout wrapper -->
    <div class="layout-wrapper layout-content-navbar">
      <div class="layout-container">
        <!-- Menu -->
        <aside id="layout-menu" class="layout-menu menu-vertical menu bg-menu-theme">
          <div class="app-brand demo">
            <a href="/dashboard" class="app-brand-link">
              <span class="app-brand-logo demo">
                <svg width="25" viewBox="0 0 25 42" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                  <defs>
                    <path d="M13.7918663,0.358365126 L3.39788168,7.44174259 C0.566865006,9.69408886 -0.379795268,12.4788597 0.557900856,15.7960551 C0.68998853,16.2305145 1.09562888,17.7872135 3.12357076,19.2293357 C3.8146334,19.7207684 5.32369333,20.3834223 7.65075054,21.2172976 L7.59773219,21.2525164 L2.63468769,24.5493413 C0.445452254,26.3002124 0.0884951797,28.5083815 1.56381646,31.1738486 C2.83770406,32.8170431 5.20850219,33.2640127 7.09180128,32.5391577 C8.347334,32.0559211 11.4559176,30.0011079 16.4175519,26.3747182 C18.0338572,24.4997857 18.6973423,22.4544883 18.4080071,20.2388261 C17.963753,17.5346866 16.1776345,15.5799961 13.0496516,14.3747546 L10.9194936,13.4715819 L18.6192054,7.984237 L13.7918663,0.358365126 Z" id="path-1"></path>
                    <path d="M5.47320593,6.00457225 C4.05321814,8.216144 4.36334763,10.0722806 6.40359441,11.5729822 C8.61520715,12.571656 10.0999176,13.2171421 10.8577257,13.5094407 L15.5088241,14.433041 L18.6192054,7.984237 C15.5364148,3.11535317 13.9273018,0.573395879 13.7918663,0.358365126 C13.5790555,0.511491653 10.8061687,2.3935607 5.47320593,6.00457225 Z" id="path-3"></path>
                    <path d="M7.50063644,21.2294429 L12.3234468,23.3159332 C14.1688022,24.7579751 14.397098,26.4880487 13.008334,28.506154 C11.6195701,30.5242593 10.3099883,31.790241 9.07958868,32.3040991 C5.78142938,33.4346997 4.13234973,34 4.13234973,34 C4.13234973,34 2.75489982,33.0538207 2.37032616e-14,31.1614621 C-0.55822714,27.8186216 -0.55822714,26.0572515 -4.05231404e-15,25.8773518 C0.83734071,25.6075023 2.77988457,22.8248993 3.3049379,22.52991 C3.65497346,22.3332504 5.05353963,21.8997614 7.50063644,21.2294429 Z" id="path-4"></path>
                    <path d="M20.6,7.13333333 L25.6,13.8 C26.2627417,14.6836556 26.0836556,15.9372583 25.2,16.6 C24.8538077,16.8596443 24.4327404,17 24,17 L14,17 C12.8954305,17 12,16.1045695 12,15 C12,14.5672596 12.1403557,14.1461923 12.4,13.8 L17.4,7.13333333 C18.0627417,6.24967773 19.3163444,6.07059163 20.2,6.73333333 C20.3516113,6.84704183 20.4862915,6.981722 20.6,7.13333333 Z" id="path-5"></path>
                  </defs>
                  <g id="g-app-brand" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
                    <g id="Brand-Logo" transform="translate(-27.000000, -15.000000)">
                      <g id="Icon" transform="translate(27.000000, 15.000000)">
                        <g id="Mask" transform="translate(0.000000, 8.000000)">
                          <mask id="mask-2" fill="white">
                            <use xlink:href="#path-1"></use>
                          </mask>
                          <use fill="#696cff" xlink:href="#path-1"></use>
                          <g id="Path-3" mask="url(#mask-2)">
                            <use fill="#696cff" xlink:href="#path-3"></use>
                            <use fill-opacity="0.2" fill="#FFFFFF" xlink:href="#path-3"></use>
                          </g>
                          <g id="Path-4" mask="url(#mask-2)">
                            <use fill="#696cff" xlink:href="#path-4"></use>
                            <use fill-opacity="0.2" fill="#FFFFFF" xlink:href="#path-4"></use>
                          </g>
                        </g>
                        <g id="Triangle" transform="translate(19.000000, 11.000000) rotate(-300.000000) translate(-19.000000, -11.000000) ">
                          <use fill="#696cff" xlink:href="#path-5"></use>
                          <use fill-opacity="0.2" fill="#FFFFFF" xlink:href="#path-5"></use>
                        </g>
                      </g>
                    </g>
                  </g>
                </svg>
              </span>
              <span class="app-brand-text demo menu-text fw-bolder ms-2">Sneat</span>
            </a>
            <a href="javascript:void(0);" class="layout-menu-toggle menu-link text-large ms-auto d-block d-xl-none">
              <i class="bx bx-chevron-left bx-sm align-middle"></i>
            </a>
          </div>
          <div class="menu-inner-shadow"></div>
          <ul class="menu-inner py-1">
            <!-- Dashboard -->
            <li class="menu-item">
              <a href="/dashboard" class="menu-link">
                <i class="menu-icon tf-icons bx bx-home-circle"></i>
                <div data-i18n="Analytics">Dashboard</div>
              </a>
            </li>
            <!--Employee-->
            <li class="menu-header small text-uppercase">
              <span class="menu-header-text">Employee</span>
            </li>
            <li class="menu-item active open">
              <a href="javascript:void(0);" class="menu-link menu-toggle">
                <i class="menu-icon tf-icons bx bx-dock-top"></i>
                <div data-i18n="Account Settings">Employees</div>
              </a>
              <ul class="menu-sub">
                <li class="menu-item">
                  <a href="employee-employees" class="menu-link">
                    <div data-i18n="All Employees">All Employees</div>
                  </a>
                </li>
                <li class="menu-item">
                  <a href="employee-registration" class="menu-link">
                    <div data-i18n="New Registration">New Registration</div>
                  </a>
                </li>
                <li class="menu-item active">
                  <a href="employee-departments" class="menu-link">
                    <div data-i18n="Departments">Departments</div>
                  </a>
                </li>
                <li class="menu-item">
                  <a href="employee-designations" class="menu-link">
                    <div data-i18n="Designations">Designations</div>
                  </a>
                </li>
                
              </ul>
            </li>
            <li class="menu-header small text-uppercase"><span class="menu-header-text">Administration</span></li>
              <li class="menu-item">
                <a href="javascript:void(0)" class="menu-link menu-toggle">
                  <i class="menu-icon tf-icons bx bx-briefcase"></i>
                  <div data-i18n="Extended UI">Jobs</div>
                </a>
                <ul class="menu-sub">
                  <li class="menu-item">
                    <a href="job-candidates" class="menu-link">
                      <div data-i18n="All Candidate">All Candidate</div>
                    </a>
                  </li>
                  <li class="menu-item">
                    <a href="job-candidate-registration" class="menu-link">
                      <div data-i18n="Perfect Scrollbar">Add Candidate</div>
                    </a>
                  </li>
                 
                </ul>
              </li>
              <li class="menu-item">
                <a href="javascript:void(0)" class="menu-link menu-toggle">
                  <i class="menu-icon tf-icons bx bx-user-check"></i>
                  <div data-i18n="Extended UI">Attendance</div>
                </a>
                <ul class="menu-sub">
                
                  <li class="menu-item">
                    <a href="employee-add-attendance" class="menu-link">
                      <div data-i18n="Perfect Scrollbar">Add Attendance</div>
                    </a>
                  </li>
                </ul>
              </li>
          </ul>
        </aside>
        <!-- / Menu -->
        <!-- Layout container -->
        <div class="layout-page">
          <!-- Navbar -->
          <nav class="layout-navbar container-xxl navbar navbar-expand-xl navbar-detached align-items-center bg-navbar-theme" id="layout-navbar">
            <div class="layout-menu-toggle navbar-nav align-items-xl-center me-3 me-xl-0 d-xl-none">
              <a class="nav-item nav-link px-0 me-xl-4" href="javascript:void(0)">
                <i class="bx bx-menu bx-sm"></i>
              </a>
            </div>
            <div class="navbar-nav-right d-flex align-items-center" id="navbar-collapse">
              <!-- Search -->
              <div class="navbar-nav align-items-center">
                <div class="nav-item d-flex align-items-center">
                  <i class="bx bx-search fs-4 lh-0"></i>
                  <input type="text" class="form-control border-0 shadow-none" placeholder="Search..." aria-label="Search..." />
                </div>
              </div>
              <!-- /Search -->
              <ul class="navbar-nav flex-row align-items-center ms-auto">
                <!-- Place this tag where you want the button to render. -->
                <li class="nav-item lh-1 me-3">
                  <a class="github-button" href="https://github.com/themeselection/sneat-html-admin-template-free" data-icon="octicon-star" data-size="large" data-show-count="true" aria-label="Star themeselection/sneat-html-admin-template-free on GitHub">Star</a>
                </li>
                <!-- User -->
                <li class="nav-item navbar-dropdown dropdown-user dropdown">
                  <a class="nav-link dropdown-toggle hide-arrow" href="javascript:void(0);" data-bs-toggle="dropdown">
                    <div class="avatar avatar-online">
                      <img src="/Content/assets/img/avatars/1.png" alt class="w-px-40 h-auto rounded-circle" />
                    </div>
                  </a>
                  <ul class="dropdown-menu dropdown-menu-end">
                    <li>
                      <a class="dropdown-item" href="#">
                        <div class="d-flex">
                          <div class="flex-shrink-0 me-3">
                            <div class="avatar avatar-online">
                              <img src="/Content/assets/img/avatars/1.png" alt class="w-px-40 h-auto rounded-circle" />
                            </div>
                          </div>
                          <div class="flex-grow-1">
                            <span class="fw-semibold d-block">John Doe</span>
                            <small class="text-muted">Admin</small>
                          </div>
                        </div>
                      </a>
                    </li>
                    <li>
                      <div class="dropdown-divider"></div>
                    </li>
                    <li>
                      <a class="dropdown-item" href="#">
                        <i class="bx bx-user me-2"></i>
                        <span class="align-middle">My Profile</span>
                      </a>
                    </li>
                    <li>
                      <a class="dropdown-item" href="#">
                        <i class="bx bx-cog me-2"></i>
                        <span class="align-middle">Settings</span>
                      </a>
                    </li>
                    <li>
                      <a class="dropdown-item" href="#">
                        <span class="d-flex align-items-center align-middle">
                          <i class="flex-shrink-0 bx bx-credit-card me-2"></i>
                          <span class="flex-grow-1 align-middle">Billing</span>
                          <span class="flex-shrink-0 badge badge-center rounded-pill bg-danger w-px-20 h-px-20">4</span>
                        </span>
                      </a>
                    </li>
                    <li>
                      <div class="dropdown-divider"></div>
                    </li>
                    <li>
                      <a class="dropdown-item" href="auth-login-basic.html">
                        <i class="bx bx-power-off me-2"></i>
                        <span class="align-middle">Log Out</span>
                      </a>
                    </li>
                  </ul>
                </li>
                <!--/ User -->
                
              </ul>
            </div>
          </nav>
          <!-- / Navbar -->
          <!-- Content wrapper -->
          <div class="content-wrapper">
            <!-- Content -->
            <div class="container-xxl flex-grow-1 container-p-y">
              <h4 class="fw-bold py-3 mb-4">
                <span class="text-muted fw-light">Employees /</span> Departments
              </h4>

			  
			  <div class="d-flex justify-content-end">
				<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#addDepartment"><i class='bx bx-plus-medical'></i> Add Department </button>
			  </div>
              <div class="row mt-4">
                <div class="col-md-12">
                  <!--
                  <ul class="nav nav-pills flex-column flex-md-row mb-3">
                    <li class="nav-item">
                      <a class="nav-link active" href="javascript:void(0);">
                        <i class="bx bxs-user-account me-1"></i> Personal Details </a>
                    </li>
                  </ul>
                  -->
				  <div class="card mb-4">
					  <h5 class="card-header">Department Names</h5>
            <hr class="my-3" />
            <div class="table-responsive text-nowrap">
              <table class="table table-striped" id="deptTable">
              <thead>
                <tr>
                <th>#</th>
                <th>Department Name</th>
                <th class="text-end">Actions</th>
                </tr>
              </thead>
              <tbody class="table-border-bottom-0">
                <% foreach (var dept in departments) { %>
                  <tr>
                    <td><%= dept.Id %></td>
                    <td><strong><%= dept.Name %></strong></td>
                    <td class="text-end">
                      <div class="dropdown">
                      <button type="button" class="btn p-0 dropdown-toggle hide-arrow" data-bs-toggle="dropdown">
                        <i class="bx bx-dots-vertical-rounded"></i>
                      </button>
                      <div class="dropdown-menu">
                        <a class="dropdown-item updateBtn" href="javascript:void(0);" onclick="editDept(this)"> <!--data-bs-toggle="modal" data-bs-target="#editDepartment"-->
                        <i class="bx bx-edit-alt me-1"></i> Edit </a>
                        <a class="dropdown-item deleteBtn" onclick="deleteDept(this)"> <!--data-bs-toggle="modal" data-bs-target="#deleteDepartment"-->
                        <i class="bx bx-trash me-1"></i> Delete </a>
                      </div>
                      </div>
                    </td>
                  </tr>
                <% } %>
                
              </tbody>
              </table>
            </div> <!--Table-->
            
            
				  </div> <!-- Card -->
                 
                </div> <!-- Col -->
              </div> <!-- Row -->
              
        <div id="successToast" class="bs-toast toast bg-success m-2 toast-placement-ex top-0 start-50 translate-middle-x" role="alert" aria-live="assertive" aria-atomic="true" data-delay="2000">
          <div class="toast-header"> <i class="bx bx-bell me-2"></i> <div class="me-auto fw-semibold">Success</div><button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button> </div>
          <div class="toast-body" id="toastMsg">Department added successfully.</div>
        </div>
        <div id="failedToast" class="bs-toast toast bg-danger m-2 toast-placement-ex top-0 start-50 translate-middle-x" role="alert" aria-live="assertive" aria-atomic="true" data-delay="2000">
          <div class="toast-header"> <i class="bx bx-bell me-2"></i> <div class="me-auto fw-semibold">Failed</div><button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button> </div>
          <div class="toast-body" id="toastFailMsg">Failed due to internal problem.</div>
        </div> 
            
        <!--addDepartment-->
			  <div class="modal fade" id="addDepartment" tabindex="-1" aria-hidden="true">
				<div class="modal-dialog modal-dialog-centered" role="document">
				  <div class="modal-content">
					<div class="modal-header">
					  <h5 class="modal-title">Add Department</h5>
					  <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
					</div>
          <form id="addDepartmentForm" runat="server">
            <div class="modal-body">
              <div class="row">
              <div class="col mb-3">
                <label for="departmentName" class="form-label">Department Name</label>
                <input type="text" id="departmentName" name="departmentName" class="form-control" placeholder="For ex. 'Wed Development'" required />
                <div id="deptMsg" class="my-2 alert alert-danger" role="alert"></div>
              </div>
              </div>
            </div>
            <div class="modal-footer">
              <button type="button" class="btn btn-outline-secondary" data-bs-dismiss="modal"> Close </button>
              <button type="button" class="btn btn-primary" id="submit_form" onclick="addDepartmentFunction()">Add Department</button> 
            </div>
          </form>
				  </div>
				</div>
			  </div> <!--/ addDepartment-->
        <!--editDepartment-->
			  <div id="editDepartment" class="modal fade" role="dialog">
          <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
            <div class="modal-header">
              <h5 class="modal-title">Edit Department</h5>
              <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
              <form>
              <div class="form-group">
                <label>Department Name <span class="text-danger">*</span>
                </label>
                <input class="form-control" id="editField" type="text" />
                <div id="deptMsg1" class="my-2 alert alert-danger" role="alert"></div>
              </div>
              </form>
            </div>
            <div class="modal-footer">
              <button type="button" class="btn btn-primary" id="editForm" onclick="updateDeptFunction()">Save</button>
            </div>
            </div>
          </div>
			  </div><!--/ editDepartment-->
        <!--deleteDepartment-->
			  <div class="modal fade" id="deleteDepartment" role="dialog">
          <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
            <div class="modal-header">
              <h5 class="modal-title">Delete Department</h5>
            </div>
            <div class="modal-body">
              <h6 class="mb-0">Are you sure want to delete?</h6>
            </div>
            <div class="modal-footer">
              <button type="button" class="btn btn-outline-secondary" data-bs-dismiss="modal"> Close </button>
              <button type="button" class="btn btn-primary" id="deleteRecordBtn" onclick="deleteDeptFunction()">Delete</button>
            </div>
              
            </div>
          </div>
			  </div> <!--/ deleteDepartment-->


              </div> <!-- Container -->
            <!-- / Content Wrapper -->
            <!-- Footer -->
            <footer class="content-footer footer bg-footer-theme">
              <div class="container-xxl d-flex flex-wrap justify-content-between py-2 flex-md-row flex-column">
                <div class="mb-2 mb-md-0"> © <script>
                    document.write(new Date().getFullYear());
                  </script> , made with ❤️ by Sawan</a>
                </div>                
              </div>
            </footer>
            <!-- / Footer -->
            <div class="content-backdrop fade"></div>
          </div>
          <!-- Content wrapper -->
        </div>
        <!-- / Layout page -->
      </div>
      <!-- Overlay -->
      <div class="layout-overlay layout-menu-toggle"></div>
    </div>

    <!-- Core JS -->
    <!-- build:js assets/vendor/js/core.js -->
    <script src="/Content/assets/vendor/libs/jquery/jquery.js"></script>
    <script src="/Content/assets/vendor/libs/popper/popper.js"></script>
    <script src="/Content/assets/vendor/js/bootstrap.js"></script>

    <script src="/Content/assets/vendor/libs/perfect-scrollbar/perfect-scrollbar.js"></script>
    <script src="/Content/assets/vendor/js/menu.js"></script>
    <!-- endbuild -->
    <!-- Vendors JS -->
    <!-- Main JS -->
    <script src="/Content/assets/js/main.js"></script>
    <!-- Page JS -->
    <!-- Place this tag in your head or just before your close body tag. -->
    <!--
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>  
    -->
    <script src="https://cdn.datatables.net/1.13.5/js/jquery.dataTables.min.js"></script>
    <script src="https://cdn.datatables.net/1.13.5/js/dataTables.bootstrap5.min.js"></script>
    

    <script type="text/javascript">
      $(document).ready( function () {
          var dTable = $('#deptTable').DataTable();
          $('#deptMsg').hide();
          $('#deptMsg1').hide();
      } );
    </script>
    <script type="text/javascript">
      function addDepartmentFunction() {
          var msgDiv = document.getElementById('deptMsg');

          var name = $("#departmentName").val();
          name = name.trim();
          if (name.length == 0 || name == "") {
            msgDiv.innerText ='Please provide a department name.';
            $('#deptMsg').show();
            $('#deptMsg').delay(3000).fadeOut();
            
            return false;
          }else{
            $('#deptMsg').hide();
          }
          var json = {};
          json.Name = name;
          //alert(json);
          $.ajax({
              type: "POST",
              url: "/addDepartment",
              contentType: "application/json; charset=utf-8",
              data: JSON.stringify(json),
              dataType: "json",
              success: function(data) {
                  //var data = JSON.parse(JSON.stringify(resp));
                  console.log(data.status);
                  if(data.status == 'success'){
                    $('#addDepartment').modal('hide');
                    //alert(data.result.Id);
                    document.getElementById('toastMsg').innerText = 'Department added successfully.';
                    var myToast = document.getElementById('successToast')
                    var successToast = new bootstrap.Toast(myToast);
                    successToast.show()

                    var dTable = $('#deptTable').DataTable();

                    dTable.row.add($('<tr><td>'+data.result.Id+'</td><td><strong>'+data.result.Name+'</strong></td><td class="text-end"><div class="dropdown"><button type="button" class="btn p-0 dropdown-toggle hide-arrow" data-bs-toggle="dropdown">'+
                    '<i class="bx bx-dots-vertical-rounded"></i></button><div class="dropdown-menu"><a class="dropdown-item updateBtn" href="javascript:void(0);" onclick="editDept(this)">'+
                    '<i class="bx bx-edit-alt me-1"></i> Edit </a><a class="dropdown-item deleteBtn" onclick="deleteDept(this)">'+
                    '<i class="bx bx-trash me-1"></i> Delete </a></div></div></td></tr>')).draw();
                  }else if(data.status == 'failed'){
                    //console.log(data.status);
                    $('#addDepartment').modal('hide');

                    document.getElementById('toastFailMsg').innerText = 'Failed due to internal problem.';
                    var myToast = document.getElementById('failedToast')
                    var failedToast = new bootstrap.Toast(myToast);
                    failedToast.show()
                  }else{
                    //console.log(data.status);
                    msgDiv.innerText = 'Found duplicate a department name.';
                    $('#deptMsg').show();
                    $('#deptMsg').delay(3000).fadeOut();
                  }                  
                  $("#departmentName").val('')
              },
              error: function(error) {
                  console.log(error);
                  document.getElementById('toastFailMsg').innerText = 'Failed due to server problem.';
                  var myToast = document.getElementById('failedToast')
                  var failedToast = new bootstrap.Toast(myToast);
                  failedToast.show()
              }
          });
      }
      /*
      $('#deptTable tbody').on( 'click', '.deleteBtn', function () {
        //$('#deleteDepartment').modal('show');
        var dTable = $('#deptTable').DataTable();
        var tr = dTable.row($(this).parents('tr'));


        //$('#deleteDepartment').on('click','#deleteRecordBtn',function(){
          //alert("button");
          //console.log(dTable.row($(this).closest('tr')).data() ); //used to print table row data
          //dTable.row($(this).parents('tr')).remove().draw(false); //used to remove table row

          //console.log(tr.data());
          //$('#deleteDepartment').modal('hide');
        //});
        
        
          $.ajax({
            type: "POST",
            url: 'deleteDepartment?id=' + tr.data()[0],
            dataType: "json",
            success: function (msg) {
              console.log(msg.status);
              if(msg.status == 'success'){
                tr.remove().draw();
              }else{
                //console.log(JSON.stringify(msg));
                var myToast = document.getElementById('failedToast')
                var failedToast = new bootstrap.Toast(myToast);
                failedToast.show()
              }
            },
            error: function (e) {
                console.log(e)
                // closeSearchModal();
            }
          });
        return;
      });
      */
      var selectedRow;
      function deleteDept(link){

        // Store the data of the selected row in the global variable
        selectedRow = $('#deptTable').DataTable().row($(link).closest('tr'));
        $('#deleteDepartment').modal('show');
      }
      function deleteDeptFunction(){
        $.ajax({
            type: "POST",
            url: 'deleteDepartment?id=' + selectedRow.data()[0],
            dataType: "json",
            success: function (msg) {
              console.log(msg.status);
              if(msg.status == 'success'){
                var table = $('#deptTable').DataTable();
                table.row(selectedRow).remove().draw();
                
                $('#deleteDepartment').modal('hide');

                document.getElementById('toastMsg').innerText = 'Department deleted successfully.';
                var myToast = document.getElementById('successToast')
                var successToast = new bootstrap.Toast(myToast);
                successToast.show()

              }else{
                //console.log(JSON.stringify(msg));
                document.getElementById('toastFailMsg').innerText = 'Failed due to internal problem.';
                var myToast = document.getElementById('failedToast')
                var failedToast = new bootstrap.Toast(myToast);
                failedToast.show()
              }
            },
            error: function (e) {
                console.log(e)
                // closeSearchModal();
                document.getElementById('toastFailMsg').innerText = 'Failed due to server problem.';
                var myToast = document.getElementById('failedToast')
                var failedToast = new bootstrap.Toast(myToast);
                failedToast.show()
            }
          });
      }
      function editDept(link) {
        var table = $('#deptTable').DataTable();
        var row = table.row($(link).closest('tr'));

        // Store the data of the selected row in the global variable
        selectedRow = row;

        // Open the modal for editing
        $("#editField").val(row.data()[1].replace('<strong>', '').replace('</strong>', '').trim());
        $('#editDepartment').modal('show');
      }

      function updateDeptFunction(){
          var rowData = selectedRow.data();
          var name= rowData[1].replace('<strong>', '').replace('</strong>', '').trim()

          var newName = $("#editField").val().trim();
          if (newName.length == 0 || newName == "") {
            document.getElementById('deptMsg1').innerText ='Please provide a department name.';
            $('#deptMsg1').show();
            $('#deptMsg1').delay(3000).fadeOut();
            
            return false;
          }else if(newName.toLowerCase() === name.toLowerCase()){
            document.getElementById('deptMsg1').innerText ='Please provide new department name.';
            $('#deptMsg1').show();
            $('#deptMsg1').delay(3000).fadeOut();
            return false;
          }else{
            $('#deptMsg1').hide();
            rowData[1] = '<strong>'+newName+'</strong>';
            selectedRow.data(rowData);
            selectedRow.draw('full-reset');

            $("#editDepartment").modal("hide");

            var json = {};
            json.Id = rowData[0];
            json.newName = rowData[1];
            console.log(json);
            document.getElementById('toastMsg').innerText = 'Department updated successfully.';
            var myToast = document.getElementById('successToast')
            var successToast = new bootstrap.Toast(myToast);
            successToast.show()
          } 
      }
     
    </script>
  </body>
</html>

   