// ----------------------------
// obs! bugg i blazor...går ej anropa arrow-function....måste anropa vanlig funktion som därefter anropar arrow-function

function alertfunc(message) {
    alert("hello" + message);
    alertfunc2(message);
}
const alertfunc2 = (message) => {
    alert("2" + message);
}
//--------------------------------


