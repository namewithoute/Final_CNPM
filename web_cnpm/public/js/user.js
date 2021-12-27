function submitchange(){
    var oldpass= document.getElementById("oldpass").value;
    var newpass=document.getElementById("newpass").value;
    var confirm=document.getElementById("changepass").value;
    if (document.getElementById("newpass").value != document.getElementById("changepass").value){
        alert("Mật khẩu xác nhận sai")
        location.reload();
    }
    else{
    var datapass={
        oldpass: oldpass,
        newpass:newpass,
        confirm:confirm,
    }

    fetch('http://localhost:3000/changepass',{
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(datapass)
        
    })
    .then(function(res){
        return res.json();
    })
    .then(function(notice){
        if(notice==="Sai pass"){
            alert("Mật khẩu cũ không đúng");
            location.reload();
        }
        else if(notice==="Success"){
            alert("Cập nhật thành công");
            location.reload();
        }
    })

    }


}


function updateinfor(){
    var hoten=document.getElementById("hoten").value;
    var sdt= document.getElementById("sdt").value;
    var email=document.getElementById("email").value;
    var diachi=document.getElementById("diachi").value;
    if(hoten==="" || sdt==="" || email==="" || email.includes("@")==false||diachi===""){
        alert("Vui lòng nhập thông tin hợp lệ và không để trống");
    }
    else{
    var infor={
        hoten:hoten,
        sdt:sdt,
        email:email,
        diachi:diachi,
    }
    fetch('http://localhost:3000/updateinfor',{
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(infor)
    })
    .then(function(res){
        return res.json()
    })
    .then(function(notice){
        if(notice=="success"){
            alert("Cập nhật thành công");
            location.reload();

        }
    })
}
}



// chức năng đăng kí
     var checkSignin = function(){
         if ((document.getElementById("usernamed").value=="")||
         (document.getElementById("hotend").value=="")||(document.getElementById("sdtd").value=="")||
         (document.getElementById("passwordd").value=="")||(document.getElementById("emaild").value=="") ){
            $(".require-signup").css("display","block");
         }
         else{
            $(".require-signup").css("display","none");
            var username=document.getElementById("usernamed").value;
            var hoten=document.getElementById("hotend").value;
            var sdt=document.getElementById("sdtd").value;
            var password=document.getElementById("passwordd").value;
            var email=document.getElementById("emaild").value;
            var address=document.getElementById("address").value
            var dataRegis={
                username: username,
                hoten: hoten,
                sdt:sdt,
                password:password,
                email:email,
                address:address,
            }


            fetch('http://localhost:3000/register',{
                method: 'POST',
                headers: {'Content-Type': 'application/json'},
                body: JSON.stringify(dataRegis)
            })
            .then(function(response){
                return response.json()
            })
            .then(function(notice){
                if(notice=='username'){
                    alert("Username đã tồn tại, xin mời quý khách thử tên khác");
                }
                else if(notice=='email'){
                    alert("Email đã tồn tại!!!")
                }
                else
                    alert("Tạo tài khoản thành công")
                window.location.href = 'login';

            })
         }
     }
 
     
     

    
var checksignup = function(event){
    if ((document.getElementById("name").value=="")||(document.getElementById("password").value=="")){
        $(".require-login").css("display","block");
        event.preventDefault();
    }
    else{
        $(".require-login").css("display","none");
    }
}


    

