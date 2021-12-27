function updatedonhang(iddon,idsp,size,tenkhach,sdt,email,diachi){
  document.getElementById("id-don").value=iddon;
  document.getElementById("id-sanpham").value=idsp;
  document.getElementById("sizec").value=size;
  document.getElementById("don-user").value=tenkhach;
  document.getElementById("don-phone").value=sdt;
  document.getElementById("don-email").value=email;
  document.getElementById("don-address").value=diachi;



}






function submitupdate(){
  var iddon= document.getElementById("id-don").value;
  var idsp= document.getElementById("id-sanpham").value;
  var size= document.getElementById("sizec").value;
  var tenkhach=document.getElementById("don-user").value;
  var sdt=document.getElementById("don-phone").value;
  var email=document.getElementById("don-email").value;
  var diachi=document.getElementById("don-address").value;
  var trangthai=document.getElementById('trangthai').value;
  if(tenkhach===''|| sdt==='' ||diachi===''){
    alert("Vui lòng không để trống")
  }
else{
  var data={
    iddon,
    idsp,
    size,
    tenkhach,
    sdt,
    email,
    diachi,
    trangthai
  }
  fetch('http://localhost:3000/updatedonhang',{
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