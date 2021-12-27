function getvalue(id,size,soluong,soluongdaban,conhang){
    document.getElementById("idd").value=id
    document.getElementById("sized").value=size;
    document.getElementById("quantityd").value=soluong;
    document.getElementById("soldd").value=soluongdaban;
    document.getElementById("availabled").value=conhang;
}



function addPro(){
    var id=document.getElementById("id").value;
    var size=document.getElementById("size").value;
    var quantity=document.getElementById("quantity").value
    var sold=document.getElementById("sold").value;
    var available=document.getElementById("available").value;
    if(id===''||quantity===''||sold===''||available===''){
        alert("Không được bỏ trống!!");
    }
    else{
    var data= {
        id,
        size,
        quantity,
        sold,
        available,
    }
    console.log(data)
    fetch('http://localhost:3000/addkho',{
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
        else{
            alert("Xin nhập đúng id")
        }
     })
    }
}


function updatePro(){
    var id=document.getElementById("idd").value;
    var size=document.getElementById("sized").value;
    var quantity=document.getElementById("quantityd").value
    var sold=document.getElementById("soldd").value;
    var available=document.getElementById("availabled").value;
    if(id===''||quantity===''||sold===''||available===''){
        alert("Không được bỏ trống!!");
    }
    else{
    var data= {
        id,
        size,
        quantity,
        sold,
        available,
    }

    fetch('http://localhost:3000/updatekho',{
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
        else{
            alert("Xin kiểm tra lại thông tin")
        }
     })
    }
}


function deletekho(id,size){
    var deid=id;
    var desize=size;
    var data={
        deid,
        desize,
    }
    if(confirm("Are you sure")){
        fetch('http://localhost:3000/deletekho',{
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