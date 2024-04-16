from django.http import HttpResponse
from django.shortcuts import render

# Create your views here.
def welcome(request):
    return render(request, 'index.html')

def User(request):

    username = request.GET['username']
    password = request.GET['password']
    phone = request.GET['phone']
    email = request.GET['email']
    otp = request.GET['otp']

    username_list = ["user" , "users" , "johndoe" , "abc"]

    print(username)

    if(username in username_list and password == 'user' and phone == '1234567890' and email == 'abc@gmail.com' and otp == '12345'):
        return render(request, 'user.html',{'name':username})
    else:
        return render(request, 'error.html')