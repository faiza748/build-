h1{
    margin: 0;
    padding: 0;
}
body{
    background: url(https://cdn.freecodecamp.org/testable-projects-fcc/images/survey-form-background.jpeg);
    background-size: cover;
    background-attachment: fixed;
}
.heading{
    text-align: center;
    width: 100%;
    margin: auto;
    margin-top: 100px;
}
#head{
    font-size: 1.8em;
}
#subheading{
    font-size: 18px;
    margin-top: 10px;
}
#content1{
    width: 90%;
    margin: auto;
}
form{
    background-color: rgba(0, 0, 0, 0,7);
    padding-top: 34px;
    display:flex ;
    align-items: center;
    justify-content: center;
    width: 54%;
    border-radius: 5px;
    margin: auto;
    margin-top: 10px;
    padding-bottom: 60px;
}
form .box{
    width: 98.5%;
    height: 2.8em;
    position: relative;
    bottom: 10px;
    border: 0;
    border-radius: 5px;
}
#option1 select{
    width: 98.5%;
    height: 2.7em;
    position: relative;
    bottom: 10px;
    border-radius: 5px;
    border:0 ;
}
#option2 select{
    width: 98.5%;
    height: 2.7em;
    position: relative;
    bottom: 10px;
    border-radius: 5px;
    border: 0;
}
#content2{
    margin-top: 10px;
}
#content2 text area{
    width:98.5%;
    height: 125px;
    position: relative;
    bottom: 17px;
}
botton{
width: 98.5%;
height: 3em;
position: relative;
top:11px;
background-color: rgb(18, 219, 78);
border: none;
color: rgb(255, 255, 2555);
margin-bottom: 10px;
cursor: pointer;
}
textarea::placeholder{
    font-size: 1.4em;
    position: relative;
     top:8px;
     left:5px;
     width: 70%;
}
input::placeholder{
    font-size: 1.1em;
    position: relative;
    left: 10px;
    width:50%;
    font-weight: 500;
}
@media  screen and (max-width: 600px;){
    from{
        width: 100%;
        margin: auto;
    }
}