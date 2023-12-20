//Các xử lí kịch bản cho index.html//

//Khai báo biến 
var def = '--- từ khóa ---';
let emp = "";
const ABC = '';

//Concrete function >< Abstract function 
function setFirstTime(){
	window.document.frmSearch.txtKeyword.value = def;
	//document.frmSearch.txtKeyword.value = def;
	//window.document.form[0].txtKeyword.value = def;
	//document.form[0].txtKeyword.value = def;
	
}

function setFirstTimeV2(){
	document.getElementById("txtKeyword").value = def;
	//document.getElementById("frmSearch").txtKeyword.value = def;
	let fn = document.getElementById("frmSearch");
}

function setFirstTimeV3(fn){
	//Truyền tham chiếu đối tượng form
	fn.txtKeyword.value = def;
}

function setKeyword(fn, isClick){
	//Lấy giá trị 
	let key = fn.txtKeyword.value;
	
	if(isClick){
	if(key.trim()==def){
		fn.txtKeyword.value = emp;
	    }
	}
	else {
		if(key.trim()==emp){
			fn.txtKeyword.value = def;
	}
}
}

function checkValidKeyword(fn){
	let key = fn.txtKeyword.value;

	var message = 'Please input keyword for search';
	
if((key.trim()==def) || (key.trim() == emp)){
	window.alert(message);
	fn.txtKeyword.focus();
	fn.txtKeyword.select();
}
			
}