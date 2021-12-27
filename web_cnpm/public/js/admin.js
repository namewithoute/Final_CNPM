
function addItem(){
    var formData = new FormData()

    var id=document.getElementById('id').value;
    var name=document.getElementById('name').value;
    var type=document.getElementById('type').value;
    var evaluate=document.getElementById('evaluate').value;
    var color=document.getElementById('color').value;
    var description=document.getElementById('description').value;
    var img=document.getElementById('img');
    var price=document.getElementById('price').value;
    // const onSelectFile = () => upload(img.files[0]);
    // img.addEventListener('change', onSelectFile, false);
    var data={
        id:id,
        name:name,
        type:type,
        evaluate:evaluate,
        color:color,
        description:description,
        price:price
    }
    formData.append('file',img.files[0]);
    console.log(formData)
    for(var x in data){
        formData.append(x,data[x])
    }

    if(id===''|| name===''|| type==='' || evaluate===''|| color===''||description===''||img.value===''||price===''){
        alert("Có trường bị trống, vui lòng nhập lại");
    }
    else{

        fetch('http://localhost:3000/addsp',{
        method:'POST',
        // headers: {'Content-type':'application/json'}, 
        body: formData,
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



function updateItem(id,name,type,danhgia,color,description,price,img){
    console.log(id,name,type,danhgia,color,description,price,img);
    document.getElementById("idd").value=id;
    document.getElementById("named").value=name;
    document.getElementById("typed").value=type;
    document.getElementById("evaluated").value=danhgia;
    document.getElementById("colord").value=color;
    document.getElementById("descriptiond").value=description;
    document.getElementById("imgd").value=img;
    document.getElementById("priced").value=price;


}


function submitUpdate(){
    var formData = new FormData()

    var id= document.getElementById("idd").value;
    var name= document.getElementById("named").value;
    var type= document.getElementById("typed").value;
    var danhgia =document.getElementById("evaluated").value;
    var color=document.getElementById("colord").value;
    var des= document.getElementById("descriptiond").value;
    var img=document.getElementById("imgd");
    var price=document.getElementById("priced").value;

    var data={
        id,
        name,
        type,
        danhgia,
        color,
        des,
        price,
    }


    formData.append('file',img.files[0]);
    console.log(formData)
    for(var x in data){
        formData.append(x,data[x])
    }

    if(id===''|| name===''|| type==='' || danhgia===''|| color===''||des===''||img===''||price===''){
        alert("Có trường bị trống, vui lòng nhập lại");
    }
    else{

  
    fetch('http://localhost:3000/updatesp',{
        method:'POST',
        body: formData,
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



function deleteItem(idsp){
    var check=confirm("Are you sure?")
    if(check==true){
    var data={idsp}
    fetch('http://localhost:3000/deletesp',{
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
