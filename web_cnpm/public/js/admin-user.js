function getvalueUpdate(username,pass,name,sdt,email,diachi,type){
    document.getElementById("username1").value=username;
    document.getElementById("name1").value=name;
    document.getElementById("password1").value=pass;
    document.getElementById("sdt1").value=sdt;
    document.getElementById("email1").value=email;
    document.getElementById("address1").value=diachi;
    document.getElementById("role1").value=type;
}


function submitUpdateAcc(){
    var username= document.getElementById("username1").value;
    var name=document.getElementById("name1").value;
    var password=document.getElementById("password1").value;
    var sdt=document.getElementById("sdt1").value;
    var email=document.getElementById("email1").value;
    var address=document.getElementById("address1").value;
    var role=document.getElementById("role1").value;
    var data={
        username,
        name,
        password,
        sdt,
        email,
        address,
        role
    }
    console.log(data)


    if(username===''||password===''||name===''||sdt===''){
        alert("Vui lòng không để trống");
    }
    else{
        
        console.log(data)
        fetch('http://localhost:3000/updateacc',{
            method:'POST',
            headers: {'Content-type':'application/json'}, 
            body: JSON.stringify(data),
          })
         .then(function(res){
             return res.json();
         })
         .then(function(notice){
            if(notice==="Success"){
            location.reload();
            }
         })
        }

}



function addAcc(){
    var username= document.getElementById("username").value;
    var name=document.getElementById("name").value;
    var password=document.getElementById("password").value;
    var sdt=document.getElementById("sdt").value;
    var email=document.getElementById("email").value;
    var address=document.getElementById("address").value;
    var role=document.getElementById("role").value;
    var data={
        username,
        name,
        password,
        sdt,
        email,
        address,
        role
    }
    console.log(data)
    if(username===''||password===''||name===''||sdt==='' ||role==''){
        alert("Vui lòng không để trống");
    }
    else if(role!='User'&& role!='Kho' && role!='Quản lý đơn hàng'){
        alert("Vui lòng nhập vai trò hợp lệ");
    }
    else{
      
        fetch('http://localhost:3000/addacc',{
            method:'POST',
            headers: {'Content-type':'application/json'}, 
            body: JSON.stringify(data),
          })
         .then(function(res){
             return res.json();
         })
         .then(function(notice){
            if(notice==="Success"){
            location.reload();
            }
         })
        }
    
}



function deleteAcc(username){
    var data={username}
    fetch('http://localhost:3000/deleteacc',{
        method:'POST',
        headers: {'Content-type':'application/json'}, 
        body: JSON.stringify(data),
      })
     .then(function(res){
         return res.json();
     })
     .then(function(notice){
        if(notice==="Success"){
        location.reload();
        }
     })

}



