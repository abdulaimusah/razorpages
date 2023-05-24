# Razor Pages Blog (Still Working On This)

This is a web application built using Razor Pages, .NET Core, and JavaScript. The application allows users to manage blog posts by fetching data from an API, displaying the posts in a list, and providing options to edit, delete, and view details of each post.

## Features

- Fetches blog post data from an API
- Displays the blog posts in a list format
- Provides options to view post details, edit post, and delete post
- Utilizes modals for a user-friendly interface
- Implements form validation for adding and editing blog posts

## Technologies Used

- ASP.NET Core Razor Pages
- C# programming language
- HTML, CSS, JavaScript
- Bootstrap (CSS framework)
- HttpClient for API integration

## Getting Started

To run this project locally, follow these steps:

1. Clone the repository: `git clone [repository-url]`
2. Navigate to the project directory: `cd razor-pages-blog-app`
3. Restore the NuGet packages: `dotnet restore`
4. Build the project: `dotnet build`
5. Run the application: `dotnet run`
6. Access the application in your web browser at `http://localhost:5000`

## Configuration

- The API endpoint URL can be configured in the `appsettings.json` file under the `ApiSettings:BaseUrl` key.

## API Integration

- The API integration is handled in the `YourAPIIntegrationClass.cs` file.
- Use the `HttpClient` class to make HTTP requests to the API endpoints.
- Implement methods to fetch data from the API, create a new item, update an existing item, and delete an item.

## File Structure

- `Pages/Index.cshtml` - The main page that displays the list of blog posts and integrates with JavaScript code.
- `Pages/Index.cshtml.cs` - The code-behind file for the main page that contains server-side logic and API integration.
- `wwwroot/js/site.js` - The JavaScript file that handles client-side functionality, including interacting with the API and managing modals.

## Contributions

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
