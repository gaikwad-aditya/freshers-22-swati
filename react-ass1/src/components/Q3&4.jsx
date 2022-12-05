import React from "react";

function Post(props) {
    console.log(props)

    const post = props.post
    return(
        <div>
            <div>userId : {post.userId}</div>
            <div>id : {post.id}</div>
            <div>title : {post.title}</div>
            <div>body : {post.body}</div>
        </div>
    )
}

const Third = () => {
    const posts = [
        {
            userId: 1,
            id: 1,
            title:'sunt aut facere repellat provident occaecati excepturi optioreprehenderit',
            body: 'quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto',
        },

        {
            userId: 1,
            id: 2,
            title: 'qui est esse',
            body: 'est rerum tempore vitae \n sequi sint nihil reprehenderit dolorbeatae ea dolores neque \nfugiat blanditiis voluptate porro vel nihilmolestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisinulla',
        },

        {
            userId: 1,
            id: 3,
            title: 'ea molestias quasi exercitationem repellat qui ipsa sit aut',
            body: 'et iusto sed quo iure\nvoluptatem occaecati omnis eligendi autad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porroeius odio et labore et velit aut',
        },
        {
            userId: 1,
            id: 4,
            title: 'eum et est occaecati',
            body: 'ullam et saepe reiciendis voluptatem adipisci\nsit amet autemassumenda provident rerum culpa\nquis hic commodi nesciunt rem teneturdoloremque ipsam iure\nquis sunt voluptatem rerum illo velit',
        },
        {
            userId: 1,
            id: 5,
            title: 'nesciunt quas odio',
            body: 'repudiandae veniam quaerat sunt sed\nalias aut fugiat sitautem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest auttenetur dolor neque',
        },
        {
            userId: 1,
            id: 6,
            title: 'dolorem eum magni eos aperiam quia',
            body: 'ut aspernatur corporis harum nihil quis providentsequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo abreprehenderit accusantium quas\nvoluptate dolores velit et doloremquemolestiae',
        },
        {
            userId: 1,
            id: 7,
            title: 'magnam facilis autem',
            body: 'dolore placeat quibusdam ea quo vitae\nmagni quis enim quiquis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequieos ea sed quas',
        },
        {
            userId: 1,
            id: 8,
            title: 'dolorem dolore est ipsam',
            body: 'dignissimos aperiam dolorem qui eum\nfacilis quibusdam animisint suscipit qui sint possimus cum\nquaerat magni maioresexcepturi\nipsam ut commodi dolor voluptatum modi aut vitae',
        },
        {
            userId: 1,
            id: 9,
            title: 'nesciunt iure omnis dolorem tempora et accusantium',
            body: 'consectetur animi nesciunt iure dolore\nenim quia ad\nveniamautem ut quam aut nobis\net est aut quod aut provident voluptas autemvoluptas',
        },
           
    ]

    return(
        <div>
            <h1>React assignment 1: Question 3 and 4</h1>

            <table>
                <thead>
                    <th>UserId</th>
                    <th>id</th>
                    <th>title</th>
                    <th>body</th>
                </thead>
                <tbody>
                    {posts.map((post) => {
                        return (
                            <tr>
                                <td> {post.userId} </td>
                                <td> {post.id} </td>
                                <td> {post.title} </td>
                                <td> {post.body} </td>
                            </tr>
                    )
                    })} 
                </tbody>
            </table>

            <hr />
            <ul>
                {posts.map((post) => {
                    return (
                    <li>
                        <Post post={post} />
                    </li>
                )
                })}
            </ul>
        </div>
    )
}

export default Third