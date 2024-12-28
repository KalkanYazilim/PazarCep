//#region CONSTANTS
const IMG_FORMAT = "data:image/png;base64,";
const DEFAULT_AVATAR_IMG = "assets/img/avatar-placeholder.png";
const GET_PROPERTY = {
  method: "GET",
  mode: "cors",
  credentials: "include",
};
const ANONYMOUS_USER = "(anonymous)";
//#endregion

//#region BINIDNG ELEMENTS
const userName = document.getElementById("profile-name-header");
const userPhoto = document.getElementById("user-img-id");
const hamburgerMenu = document.querySelector(".navbar-toggler");
const userAdminMenu = document.getElementById("user-admin-menu-id");
const userInfoMenu = document.querySelector(".user-list");
const redirectBtn = document.getElementById("login-link-id");
const userMenu = document.getElementById("user-menu-id");
const portalServiceLink = document.getElementById("portal-service-link");
const isAdminMenu = document.getElementById("user-admin-menu-id-1");
//#endregion

//#region LOAD COMPONENT
window.addEventListener("load", async () => {
  portalServiceLink.addEventListener("click", (event) => {
    event.preventDefault();
    window.location.href = `${window.location.origin}/${getServiceName()}`;
  });

  const user = await whoAmI();
  if (user.UserName != ANONYMOUS_USER) {
    const response = await getPersonalInfo();


    if (!response.isAdmin) {

      if ($(window).width() <= 992) {
        userMenu.style.top = "10rem";
      }
    } else {
      isAdminMenu.classList.remove("d-none")
      if ($(window).width() <= 992) {
        userMenu.style.top = "12rem";
      }
    }

    userName.innerHTML = response.fullName;

    if (response.profilePicture) {
      userPhoto.src = `${IMG_FORMAT}${response.profilePicture}`;
    } else {
      userPhoto.src = DEFAULT_AVATAR_IMG;
    }
  } else {
    userAdminMenu.classList.add("d-none");
    hamburgerMenu.classList.add("d-none");
    userInfoMenu.classList.add("d-none");
    redirectBtn.classList.add("ml-auto");
    redirectBtn.classList.remove("d-none");
  }
});
//#endregion

//#region BACKEND CALLING
//#region AUTHORIZING
const whoAmI = async () => {
  try {
    const url = `${getAuthDomain()}/oauth/api/web/v1/LoginAndSignup/WhoAmI`;
    const response = await fetch(url, GET_PROPERTY);

    return await response.json();
  } catch (error) {
    console.log(error);
  }
};
//#endregion

//#region GET FUNCTIONS
const getPersonalInfo = async () => {
  try {
    const url = `${getAuthDomain()}/oauth/api/web/v3/personalInfo`;
    let response = await fetch(url, GET_PROPERTY);

    return await response.json();
  } catch (error) {
    console.log(error);
  }
};
//#endregion

//#endregion

//#region HELPERS

const getAuthDomain = () => {
  // any address with localhost goes to stable
  if (location.href.indexOf("localhost") > -1) {
    return `https://my.dev.gamanet.com`;
  }

  if (location.href.indexOf("127.0.0.1") > -1) {
    return `https://my.dev.gamanet.com`;
  }
  
  return ``;
};

const getServiceName = () => window.location.href.split("/")[3];
//#endregion
