package com.example.chakravyuh;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;


import com.example.chakravyuh.R;

public class login extends AppCompatActivity {

    private EditText usernameEditText;
    private EditText passwordEditText;
    private Button loginButton;

    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        // Find views by their corresponding IDs
        usernameEditText = findViewById(R.id.usernameEditText);
        passwordEditText = findViewById(R.id.passwordEditText);
        loginButton = findViewById(R.id.loginButton);

        // Set click listener for the login button
        loginButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Get the entered username and password
                String username = usernameEditText.getText().toString();
                String password = passwordEditText.getText().toString();


                // Validate the username and password
                if (username.equals("admin") && password.equals("password")) {
                    // Authentication successful
                    Toast.makeText(login.this, "Login successful", Toast.LENGTH_SHORT).show();
                    // Proceed to the next activity or perform other actions

                    Intent intent1 = new Intent(login.this, dashboard.class);
                    startActivity(intent1);
                    finish();


                } else {
                    // Authentication failed
                    Toast.makeText(login.this, "Invalid credentials", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}
