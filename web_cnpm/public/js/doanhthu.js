function doanhthu(){
    var getSelectedValue = document.querySelector( 'input[name="option"]:checked').value;   

fetch('http://localhost:3000/datadoanhthu')
  .then(function(res){
      return res.json();
  })
  .then(function(data){
        for(var i=0;i<data.length;i++){
            var arrNgayDat=data[i].ngay_dathang.slice(0,10).split('-');
            data[i]["ngay_dathang"]=arrNgayDat;
        }
        if(getSelectedValue=="day"){
            var getDay=document.getElementById("selectday").value.split('-')
            var res=[];

            for(var x=0;x<data.length;x++){
                if(data[x].ngay_dathang[0]==getDay[0] &&data[x].ngay_dathang[1]==getDay[1] &&data[x].ngay_dathang[2] ==getDay[2] ){
                    res.push(data[x])
                }
            }
            console.log(res)
           tongdon(res)
        }
        else if(getSelectedValue=="month"){
            var getMonth=document.getElementById("selectmonth").value;
            var res=[];
            
            for(var x=0;x<data.length;x++){
                if(data[x].ngay_dathang[1]==getMonth ){
                    res.push(data[x])
                }
            }
            tongdon(res)
        }
    })
}


function tongdon(data){
    var iddon=[];
    for(var i=0;i<data.length;i++){
        if(!iddon.includes(data[i].id_donhang)){
            iddon.push(data[i].id_donhang);
    }
}
    document.getElementById("tongdon").innerHTML=iddon.length;

    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency',
        currency: 'VND',
        minimumFractionDigits: 0
      })
    var tongtien=0;
    var donthanhcong=0;
    var donhuy=0;
    var iddonthanhcong=[]
    for (var i=0;i<data.length;i++){
        if(data[i].trang_thai=="Giao thành công"){
            tongtien+=data[i].gia_tien
            if(!iddonthanhcong.includes(data[i].id_donhang)){
                iddonthanhcong.push(data[i].id_donhang)
                donthanhcong+=1
            }

        }
        else if(data[i].trang_thai=="Đã hủy"){
            donhuy+=1
        }
      
    }
    document.getElementById("thunhap").innerHTML=formatter.format(tongtien);
    document.getElementById("donthanhcong").innerHTML=donthanhcong;
    document.getElementById("donhuy").innerHTML=donhuy;
}

function selectOption(option){
    console.log(option.value)
    if(option.value=="day"){
    document.getElementById("selectday").style.display="block";
    document.getElementById("selectmonth").style.display="none";

    }
    else if(option.value=="month"){
         document.getElementById("selectmonth").style.display="block";
          document.getElementById("selectday").style.display="none";


}
}