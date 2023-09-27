import React, { useState, useEffect } from 'react';

const ShowOrders = () => {
    const [orders, setOrders] = useState([]);
    const orderType = 1;

    useEffect(() => {
        fetch(`order/${orderType}`)
            .then((result) => {
                return result.json();
            })
            .then(order => {
                setOrders(order);
            })

    }, []);

    return (
        <main>
            {
                (orders != null) ? orders.map((order) => <h3>{order.description}</h3>) : <div>Loading....</div>
            }
        </main>
    )
}

export default ShowOrders;